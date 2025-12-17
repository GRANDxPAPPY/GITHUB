using System.Linq;
//             {
namespace WinFormsApp1
{
    using System.ComponentModel;
    using System.Windows.Forms;

    public class Product
    {
        public BindingList<Part> AssociatedParts { get; set; } = new BindingList<Part>();
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }


        public void addAssociatedPart(Part Part) {
            AssociatedParts.Add(Part);
        }

        public void removeAssociatedPart(int PartID)
        {
            if (AssociatedParts.FirstOrDefault(p => p.PartID == PartID) != null)
            {
                AssociatedParts.Remove(AssociatedParts.FirstOrDefault(p => p.PartID == PartID));
            }
        }

        public Part lookupAssociatedPart(int Part)
        {


            var searchPart = AssociatedParts
                             .FirstOrDefault(s => Convert.ToInt32(s.PartID) == Part);
            if (searchPart == null)
            {
                return null;
            }
            else
            {
                return searchPart;
            }
        }
    } }