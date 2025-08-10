using CleantosafeAssetsManager.DTO;
using RestSharp;
using System.Text.Json;

namespace CleantosafeAssetsManager
{
    /*
     *  ===========================================================================
     *  작성자     : @yoon
     *  최초 작성일: 2025.07.22
     *  
     *  < 목적 >
     *  - CleantosafeAssetsManager의 Inventory-Chemical 화면을 구현한다.
     *  
     *  < TODO >
     *  -
     *  
     *  < History >
     *  2025.07.22 @yoon
     *  - 최초 작성
     *  ===========================================================================
     */

    public partial class ChemicalControl : CustomControlBase<InventoryChemical_DTO>
    {
        // ====================================================================
        // CONSTANTS
        // ====================================================================

        private const string FILE_NAME = "inventory\\chemical_resources.json";

        private const string TYPE = "inventory/chemical";


        // ====================================================================
        // CONSTRUCTORS
        // ====================================================================

        public ChemicalControl() : base(FILE_NAME, TYPE)
        {
            InitializeComponent();

            btnAdd.Click    += DisplayAddForm;
            btnUpdate.Click += DisplayUpdateForm;
            btnRemove.Click += Remove;

            UpdateList();
        }


        // ====================================================================
        // METHODS
        // ====================================================================

        protected override void UpdateList()
        {
            if (!Value.TryGetAll(out InventoryChemical_DTO[]? chemicals))
                return;

            if (chemicals == null || chemicals.Length < 1)
                return;

            lvList.SuspendLayout();
            // update list
            foreach (InventoryChemical_DTO chemical in chemicals)
            {
                string name = chemical.Name;
                string brand = chemical.BrandName;
                string qty = chemical.Qty.ToString();
                InventoryChemical_DTO.MinMax? pHRaw = chemical.pH;
                string pH = pHRaw?.ToString() ?? string.Empty;
                string Purpose = chemical.Purpose;
                string description = chemical.Description;

                // create lvHRList.Item
                ListViewItem item = new ListViewItem(name);
                item.SubItems.AddRange([brand, qty, pH, Purpose, description]);

                item.Tag = chemical;

                // add item in lvHRList
                lvList.Items.Add(item);
            }
            lvList.ResumeLayout();
        }


        // ====================================================================
        // METHODS - EVENT
        // ====================================================================

        private void DisplayAddForm(object? sender, EventArgs e)
        {
            using AddUpdateChemical auChemical = new AddUpdateChemical(EFormOpenReason.Add);
            using AddUpdateForm form = new AddUpdateForm(auChemical)
            {
                ClientSize = auChemical.Size,
            };

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                InventoryChemical_DTO result = auChemical.Result;
                Value.Add(result);

#if RESTful
                // create body
                string json = JsonSerializer.Serialize(result);
                RestRequest request = new RestRequest("post", Method.Post)
                    .AddStringBody(json, ContentType.Json);
                RestResponse response = Client.ExecutePost(request);
                // add
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
                string pH = result.pH?.ToString() ?? string.Empty;
                item.SubItems.AddRange([result.BrandName, result.Qty.ToString(), pH, result.Purpose, result.Description]);
                item.Tag = result;
                lvList.Items.Add(item);
            }
        }

        private void DisplayUpdateForm(object? sender, EventArgs e)
        {
            if (lvList.SelectedItems.Count < 1)
                return;

            InventoryChemical_DTO? chemical = lvList.SelectedItems[0].Tag as InventoryChemical_DTO;
            if (chemical == null)
                return;

            using AddUpdateChemical auChemical = new AddUpdateChemical(EFormOpenReason.Update, chemical);
            using AddUpdateForm form = new AddUpdateForm(auChemical)
            {
                ClientSize = auChemical.Size,
            };

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                InventoryChemical_DTO result = auChemical.Result;

                ListViewItem item = lvList.SelectedItems[0];
#if RESTful
                string json = JsonSerializer.Serialize(result);
                RestRequest request = new RestRequest("put", Method.Post)
                    .AddStringBody(json, ContentType.Json);
                RestResponse response = Client.ExecutePut(request);
#else
                // update chemical
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
                string pH = result.pH?.ToString() ?? string.Empty;
                item.SubItems.AddRange([result.BrandName, result.Qty.ToString(), pH, result.Purpose, result.Description]);
            }
        }

        private void Remove(object? sender, EventArgs e)
        {
            if (lvList.SelectedItems.Count < 1)
                return;

            if (lvList.SelectedItems[0].Tag is not InventoryChemical_DTO select)
                return;

#if RESTful
            string json = JsonSerializer.Serialize(select.Guid);
            RestRequest request = new RestRequest("delete", Method.Delete)
                .AddStringBody(json, ContentType.Json);
            RestResponse response = Client.ExecuteDelete(request);
#else
            // delete
            if (!Value.TryDelete(select.Guid))
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
    }
}
