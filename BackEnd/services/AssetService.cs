using BackEnd.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.services
{
    public class AssetService
    {
        private List<Asset> assetsList;

        public AssetService()
        {
            List<Asset> assetsList1 = new List<Asset>();
            assetsList = assetsList1;
        }

        public List<Asset> GetAllAssets()
        {      
            return assetsList;
        }

        public int AddNewAsset(int ID, string NAME, string DESCRIPTION, DateOnly RECIVINGDATE, DateOnly RETURNDATE, string INVOICENUMBER, DateOnly INVOICEDAY, double VALUE)
        {
            Asset asset = new Asset();
            asset.Id = ID;
            asset.Name = NAME;
            asset.Description = DESCRIPTION;
            asset.RecivingDate = RECIVINGDATE;
            asset.ReturnDate = RETURNDATE;
            asset.InvoiceNubmer = INVOICENUMBER;
            asset.InvoiceDate = INVOICEDAY;
            asset.Value = VALUE;

            assetsList.Add(asset);

            return asset.Id;
        }

        public void DelAsset(int ID)
        {
            foreach (Asset asset in assetsList)
            {
                if (asset.Id == ID)
                {
                    assetsList.Remove(asset);
                    break;
                }
            }
        }
    }
}
