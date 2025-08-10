using CleantosafeAssetsManager.DTO;
using RestSharp;
using System.Text.Json;

namespace CleantosafeAssetsManager
{
    /*
     *  ===========================================================================
     *  작성자     : @yoon
     *  최초 작성일: 2025.07.23
     *  
     *  < 목적 >
     *  - CleantosafeAssetsManager의 Inventory-Equipment 화면을 구현한다.
     *  
     *  < TODO >
     *  -
     *  
     *  < History >
     *  2025.07.23 @yoon
     *  - 최초 작성
     *  ===========================================================================
     */

    public partial class EquipmentControl : CustomControlBase<InventoryEquipment_DTO>
    {

        // ====================================================================
        // CONSTANTS
        // ====================================================================

        private const string FILE_NAME = "inventory\\equipment_resources.json";

        private const string TYPE = "inventory/equipment";


        // ====================================================================
        // CONSTRUCTORS
        // ====================================================================

        public EquipmentControl() : base(FILE_NAME, TYPE)
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
            if (!Value.TryGetAll(out InventoryEquipment_DTO[]? equipment))
                return;

            if (equipment == null || equipment.Length < 1)
                return;

            lvList.SuspendLayout();
            // update list
            foreach (InventoryEquipment_DTO chemical in equipment)
            {
                string name = chemical.Name;
                string brand = chemical.BrandName;
                string qty = chemical.Qty.ToString();
                string Purpose = chemical.Purpose;
                string description = chemical.Description;

                // create lvHRList.Item
                ListViewItem item = new ListViewItem(name);
                item.SubItems.AddRange([brand, qty, Purpose, description]);

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
            using AddUpdateEquipment auEquipment = new AddUpdateEquipment(EFormOpenReason.Add);
            using AddUpdateForm form = new AddUpdateForm(auEquipment)
            {
                ClientSize = auEquipment.Size,
            };

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                InventoryEquipment_DTO result = auEquipment.Result;
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
                item.SubItems.AddRange([result.BrandName, result.Qty.ToString(), result.Purpose, result.Description]);
                item.Tag = result;
                lvList.Items.Add(item);
            }
        }

        private void DisplayUpdateForm(object? sender, EventArgs e)
        {
            if (lvList.SelectedItems.Count < 1)
                return;

            InventoryEquipment_DTO? equipment = lvList.SelectedItems[0].Tag as InventoryEquipment_DTO;
            if (equipment == null)
                return;

            using AddUpdateEquipment auChemical = new AddUpdateEquipment(EFormOpenReason.Update, equipment);
            using AddUpdateForm form = new AddUpdateForm(auChemical)
            {
                ClientSize = auChemical.Size,
            };

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                InventoryEquipment_DTO result = auChemical.Result;

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
                item.SubItems.AddRange([result.BrandName, result.Qty.ToString(), result.Purpose, result.Description]);
            }
        }

        private void Remove(object? sender, EventArgs e)
        {
            if (lvList.SelectedItems.Count < 1)
                return;

            if (lvList.SelectedItems[0].Tag is not InventoryEquipment_DTO select)
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
