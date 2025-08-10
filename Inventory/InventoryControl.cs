namespace CleantosafeAssetsManager
{
    public partial class InventoryControl : UserControl
    {
        // ====================================================================
        // CONSTRUCTORS
        // ====================================================================

        public InventoryControl()
        {
            InitializeComponent();

            ChemicalControl chemicalControl = new ChemicalControl() { Dock = DockStyle.Fill };
            EquipmentControl equipmentControl = new EquipmentControl() { Dock = DockStyle.Fill };
            SuppliesControl suppliesControl = new SuppliesControl() { Dock = DockStyle.Fill };

            tpChemical.Controls.Add(chemicalControl);
            tpEquipment.Controls.Add(equipmentControl);
            tpSupplies.Controls.Add(suppliesControl);
        }
    }
}
