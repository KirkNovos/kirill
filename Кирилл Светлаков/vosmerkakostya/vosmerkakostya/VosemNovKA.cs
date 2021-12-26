using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace vosmerkakostya
{
    class VosemNovKA
    {
        Connect con = new Connect();
        string[] si = new string[21];
        string[] np = new string[21];
        string[] st = new string[21];
        string[] sd = new string[21];
        string[] ar = new string[21];
        string[] mt = new string[21];
        string[] mts = new string[21];
        string[] sel = new string[21];
        DataTable DtList = new DataTable();
        DataTable dr;

        public VosemNovKA()
        {
            DtList.TableName = "NewTab";
            DtList.Columns.Add("id", typeof(int));
            DtList.Columns.Add("Image", typeof(string));
            DtList.Columns.Add("title", typeof(string));
            DtList.Columns.Add("Description", typeof(string));
            DtList.Columns.Add("MinCostForAgent", typeof(string));
            DtList.Columns.Add("ProductTypeID", typeof(string));
            DtList.Columns.Add("NameMaterial", typeof(string));
        }

        public DataTable ForList(int min1, int max1)
        {
            DtList.Clear();
            int j = 0;
            for (int i = min1; i < max1; i++)
            {
                si[j] = "SELECT Image from products_k_import where id='" + i + "'";
                np[j] = "SELECT title from products_k_import where id='" + i + "'";
                sd[j] = "SELECT Article from products_k_import where id='" + i + "'";
                st[j] = "SELECT MinCost from products_k_import where id='" + i + "'";
                ar[j] = "SELECT ProductType from products_k_import where id='" + i + "'";
                mt[j] = "SELECT typeproduct from products_k_import p, productmaterial_k_import pm " +
                "where p.id='" + i + "' and pm.Product=p.Title";
                dr = con.ConDT(mt[j]);
                foreach (DataRow dr1 in dr.Rows) mts[j] = mts[j] + "; " + dr1[0];
                DtList.Rows.Add(j + 1, con.SEL(si[j]), con.SEL(sd[j]), con.SEL(np[j]),
                con.SEL(st[j]), con.SEL(ar[j]), mts[j]);
                j++;
            }
            return DtList;
        }
    }
}

