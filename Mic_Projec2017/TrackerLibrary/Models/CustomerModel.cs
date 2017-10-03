using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class CustomerModel
    {
        public int Cust_Id { get; set; }
        public string CustomerNama { get; set; }
        public string CustomerAlamat { get; set; }
        public string CustomerKota { get; set; }
        public string CustomerTlp { get; set; }
        public string CustomerPic { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerInputBy { get; set; }
        public DateTime CustomerInputTgl { get; set; }

        //public CustomerModel()
        //{

        //}
        //public CustomerModel(
        //    string customerNama,
        //    string customerAlamat,
        //    string customerKota,
        //    string customerTlp,
        //    string customerPic,
        //    string customerEmail,
        //    string customerInputBy)
        //{
        //    CustomerNama = customerNama;
        //    CustomerAlamat = customerAlamat;
        //    CustomerKota = customerKota;
        //    CustomerTlp = customerTlp;
        //    CustomerPic = customerPic;
        //    CustomerEmail = customerEmail;
        //    CustomerInputBy = customerInputBy;
        //    //DateTime.Parse(customerInputTgl);
        //}
        //public CustomerModel(string cust_id, string customerNama)
        //{
        //    int Cust_Id = int.Parse(cust_id);
        //    CustomerNama = customerNama;
        //}
        //public CustomerModel(string customerSearch)
        //{
        //    CustomerSearch = customerSearch;
        //}
    }    
}
