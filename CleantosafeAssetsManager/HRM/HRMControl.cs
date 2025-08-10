using System.Reflection;
using System.Text.Json;
using CleantosafeAssetsManager.DTO;
using Generalibrary;
using RestSharp;

namespace CleantosafeAssetsManager
{
    /*
     *  ===========================================================================
     *  작성자     : @yoon
     *  최초 작성일: 2025.06.29
     *  
     *  < 목적 >
     *  - CleantosafeAssetsManager의 HRM 화면을 구현한다.
     *  
     *  < TODO >
     *  2025.06.30 @yoon
     *  - Main 화면의 Status 바와 연동할 항목이 있어보인다. 예를들어
     *    - 아이템을 선택했는데 업데이트가 되지 않는 등의 로그 (될 수 없었던 이유 ..?)
     *  
     *  < History >
     *  2025.06.29 @yoon
     *  - 최초 작성
     *  2025.07.03 @yoon
     *  - [U] 인적 자원 관리 파일을 xml -> json
     *  - [A] 추가, 수정, 삭제
     *  - [A] 상세 정보 선택하여 추가 정보 표시
     *  2025.07.07 @yoon
     *  - [U] 로컬 json을 사용하던 형태에서 RESTful 서버에서 데이터를 받아오는 형식으로 수정 중
     *  2025.07.22 @yoon
     *  - [U] 공통점이 있는 다른 화면을 만듦에 따라 CustomControlBase<T>를 상속받는 구조로 변경
     *  ===========================================================================
     */

    public partial class HRMControl : CustomControlBase<HRMHuman_DTO>
    {
        // ====================================================================
        // CONSTANTS
        // ====================================================================

        private const string TYPE = "hrm";

        private const string FILE_NAME = $"{TYPE}\\human_resources.json";


        // ====================================================================
        // FIELDS
        // ====================================================================

        private readonly string LOG_TYPE;

        private readonly ILog LOG = LogManager.Instance;


        // ====================================================================
        // CONSTRUCTORS
        // ====================================================================

        public HRMControl() : base(FILE_NAME, TYPE)
        {
            LOG_TYPE = this.GetType().Name;

            InitializeComponent();

            // chain event
            lvList.SelectedIndexChanged           += ChangeDetailGroupBoxName;
            lvList.SelectedIndexChanged           += UpdateDetailSelecterItems;
            btnAdd.Click                          += DisplayAddHumanForm;
            btnUpdate.Click                       += DisplayUpdateHumanForm;
            btnRemove.Click                       += RemoveHuman;
            cbDetailSelector.SelectedIndexChanged += DisplayDetailInfo;

            UpdateList();
        }


        // ====================================================================
        // METHODS
        // ====================================================================

        /// <summary>
        /// 리스트를 업데이트 한다.
        /// </summary>
        protected override void UpdateList()
        {
            if (!Value.TryGetAll(out HRMHuman_DTO[]? humans))
                return;

            if (humans == null || humans.Length < 1)
                return;

            lvList.SuspendLayout();
            // update list
            foreach (HRMHuman_DTO human in humans)
            {
                string name        = human.Name;
                string phoneNumber = human.PhoneNumber;
                DateTime birthDate   = human.BirthDate;
                string gender      = human.Gender;
                string address     = human.Address;

                // create lvHRList.Item
                ListViewItem item = new ListViewItem(name);
                item.SubItems.AddRange(new string[] { phoneNumber, birthDate.ToString("yyMMdd"), gender, address });

                item.Tag = human;

                // add item in lvHRList
                lvList.Items.Add(item);
            }
            lvList.ResumeLayout();
        }


        // ====================================================================
        // METHODS - EVENTS
        // ====================================================================

        /// <summary>
        /// <seealso cref="gbDetail"/>의 <seealso cref="Control.Name"/>을 수정한다.
        /// </summary>
        /// <param name="sender"><seealso cref="lvList"/></param>
        /// <param name="e"><seealso cref="ListView.SelectedIndexChanged"/></param>
        private void ChangeDetailGroupBoxName(object? sender, EventArgs e)
        {
            if (sender is not ListView lv)
                return;

            if (lv.SelectedItems.Count < 1)
                return;

            ListViewItem item = lv.SelectedItems[0];
            string name = item.Text;

            gbDetail.Text = $"[{name}] 상세 정보";
        }

        /// <summary>
        /// <seealso cref="lvList"/>에서 선택한 인원에 상세 정보가 존재하다면 <seealso cref="cbDetailSelector"/>를 업데이트 한다.
        /// </summary>
        /// <param name="sender"><seealso cref="lvList"/></param>
        /// <param name="e"><seealso cref="ListView.SelectedIndexChanged"/></param>
        private void UpdateDetailSelecterItems(object? sender, EventArgs e)
        {
            if (sender is not ListView lv)
                return;

            if (lv.SelectedItems.Count < 1)
                return;

            HRMHuman_DTO? human = lv.SelectedItems[0].Tag as HRMHuman_DTO;
            if (human == null)
                return;

            // get human data
            cbDetailSelector.Items.Clear();
            if (human.SamsungSDI != null)
                cbDetailSelector.Items.Add(nameof(human.SamsungSDI));
            if (human.SKHynix != null)
                cbDetailSelector.Items.Add(nameof(human.SKHynix));
        }

        /// <summary>
        /// 인원 추가 화면을 표시한다. <br/>
        /// 이후 완료 결과에 따라 추가 혹은 취소 한다. <br/>
        /// - DialogResult.OK: 추가 <br/>
        /// - else: 취소
        /// </summary>
        /// <param name="sender"><seealso cref="btnAdd"/></param>
        /// <param name="e"><seealso cref="Control.Click"/></param>
        private void DisplayAddHumanForm(object? sender, EventArgs e)
        {
            using AddHuman form = new AddHuman();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                HRMHuman_DTO result = form.Result;
                Value.Add(result);
#if RESTful
                    // create body
                    string json = JsonSerializer.Serialize(result);
                    RestRequest request = new RestRequest("post", Method.Post)
                        .AddStringBody(json, ContentType.Json);
                    RestResponse response = Client.ExecutePost(request);
                    // add HRM
                    Value.Add(result);
#else
                // save file
                if (!Value.TryGetAll(out var r) || r == null)
                    return;
                string json = JsonSerializer.Serialize(r);
                FileIO.SaveFile(json);
#endif
                // add lvHRList
                ListViewItem item = new ListViewItem();
                item.Text = result.Name;
                item.SubItems.AddRange(new string[] { result.PhoneNumber, result.BirthDate.ToString("yyMMdd"), result.Gender, result.Address });
                item.Tag = result;
                lvList.Items.Add(item);
            }
        }

        /// <summary>
        /// 인원 수정 화면을 표시한다. <br/>
        /// 이후 완료 결과에 따라 추가 혹은 취소 한다. <br/>
        /// - DialogResult.OK: 추가 <br/>
        /// - else: 취소
        /// </summary>
        /// <param name="sender"><seealso cref="btnUpdate"/></param>
        /// <param name="e"><seealso cref="Control.Click"/></param>
        private void DisplayUpdateHumanForm(object? sender, EventArgs e)
        {
            if (lvList.SelectedItems.Count < 1)
                return;

            HRMHuman_DTO? human = lvList.SelectedItems[0].Tag as HRMHuman_DTO;
            if (human == null)
                return;

            using UpdateHuman form = new UpdateHuman(human);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                HRMHuman_DTO result = form.Result;

                ListViewItem item = lvList.SelectedItems[0];

#if RESTful
                string json = JsonSerializer.Serialize(result);
                RestRequest request = new RestRequest("put", Method.Post)
                    .AddStringBody(json, ContentType.Json);
                RestResponse response = Client.ExecutePut(request);
#else
                // update HRM
                if (!Value.TryUpdate(result))
                    return;
                // save file
                if (!Value.TryGetAll(out var r) || r == null)
                    return;
                string json = JsonSerializer.Serialize(r);
                FileIO.SaveFile(json);
#endif
                // update lvHRList
                item.SubItems.Clear();
                item.Text = result.Name;
                item.SubItems.AddRange(new string[] { result.PhoneNumber, result.BirthDate.ToString("yyMMdd"), result.Gender, result.Address });
            }
        }

        /// <summary>
        /// <seealso cref="lvList"/>에서 선택한 인원을 삭제한다.
        /// </summary>
        /// <param name="sender"><seealso cref="btnRemove"/></param>
        /// <param name="e"><seealso cref="Control.Click"/></param>
        private void RemoveHuman(object? sender, EventArgs e)
        {
            string doc = MethodBase.GetCurrentMethod().Name;

            if (lvList.SelectedItems.Count < 1)
                return;

            if (lvList.SelectedItems[0].Tag is not HRMHuman_DTO selectHuman)
                return;

#if RESTful
            string json = JsonSerializer.Serialize(selectHuman.Guid);
            RestRequest request = new RestRequest("delete", Method.Delete)
                .AddStringBody(json, ContentType.Json);
            RestResponse response = Client.ExecuteDelete(request);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                LOG.Error(LOG_TYPE, doc, $"{response.StatusCode} error: {response.ErrorMessage}");
                return;
            }
#else
            // delete hr
            if (!Value.TryDelete(selectHuman.Guid))
                return;

            // save file
            if (!Value.TryGetAll(out var r) || r == null)
                return;
            string json = JsonSerializer.Serialize(r);
            FileIO.SaveFile(json);
#endif
            // remove lvHRList
            lvList.Items.Remove(lvList.SelectedItems[0]);
        }

        /// <summary>
        /// <seealso cref="cbDetailSelector"/>에서 선택한 아이템에 따라 상세 정보를 표시한다.
        /// </summary>
        /// <param name="sender"><seealso cref="cbDetailSelector"/></param>
        /// <param name="e"><seealso cref="Control.Click"/></param>
        private void DisplayDetailInfo(object? sender, EventArgs e)
        {
            if (sender is not ComboBox cb)
                return;
            if (lvList.SelectedItems.Count < 1)
                return;
            if (lvList.SelectedItems[0].Tag is not HRMHuman_DTO human)
                return;

            string select = cb.Text;

            Control? detail = null;
            if (select.Equals(nameof(HRMHuman_DTO.SamsungSDI)) && human.SamsungSDI != null)
            {
                SamsungSDIDetailInfo sdiDetail = new SamsungSDIDetailInfo(human.SamsungSDI);
                detail = sdiDetail;
            }
            else if (select.Equals(nameof(HRMHuman_DTO.SKHynix)) && human.SKHynix != null)
            {
                SKHynixDetailInfo sKHynixDetailInfo = new SKHynixDetailInfo(human.SKHynix);
                detail = sKHynixDetailInfo;
            }

            if (detail == null)
                return;

            detail.Dock = DockStyle.Fill;
            foreach (Control control in pnlDetailView.Controls)
                control.Dispose();
            pnlDetailView.Controls.Add(detail);
        }
    }
}
