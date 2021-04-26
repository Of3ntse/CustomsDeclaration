using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomsDeclaration.Models
{
    public class CustomsDeclarationRequest
    {        
        public string operatorName { get; set; }
        public string referenceNo { get; set; }
        public string passCode { get; set; }
        public DeclarationHeaderDTO declarationHeaderDTO { get; set; }
       // public string declarationHeaderDT { get; set; }

    }
    public class DeclarationHeaderDTO
    {
        public string regime_id { get; set; }
        public string cpc_group_id_int { get; set; }
        public string office_of_declaration_id { get; set; }
        public string trader_reference { get; set; }
        public string country_of_export_id { get; set; }
        public string country_of_destination_id { get; set; }
        public string place_of_discharge_id { get; set; }
        public string port_of_entry_id { get; set; }
        public string port_of_exit_id { get; set; }
        public string remarks { get; set; }
        public string declarant_name { get; set; }
        public string exporter_id_int { get; set; }
        public string exporter_others_flag { get; set; }
        public string exporter_name { get; set; }
        public string importer_id_int { get; set; }
        public string importer_others_flag { get; set; }
        public string importer_code { get; set; }
        public string mode_of_transport { get; set; }
        public string consignor_id_int { get; set; }
        public string consignor_same_flag { get; set; }
        public string consignor_code { get; set; }
        public string consignor_name { get; set; }
        public string consignee_id_int { get; set; }
        public string consignee_same_flag { get; set; }
        public string consignee_code { get; set; }
        public string consignee_name { get; set; }
        public string credit_account_party_int { get; set; }
        public string provisional_dec_number { get; set; }
        public string declaration_number { get; set; }
        public DeclarationBLDTO declarationBLDTO { get; set; }
        public DeclarationChargeDTOList declarationChargeDTOList { get; set; }
        public DeclarationInvoiceDTOList[] declarationInvoiceDTOList { get; set; }
        public DeclarationItemDTOList[] declarationItemDTOList { get; set; }
        public DeclarationDocumentDTOList[] declarationDocumentDTOList { get; set; } //new
    }
    
    public class DeclarationBLDTO
    {
        public decimal? total_gross_weight { get; set; }
        public string total_gross_weight_uom_id { get; set; }
        public int total_no_of_packages { get; set; }
        public string total_no_of_packages_uom_id { get; set; }
        public string bill_of_lading_id { get; set; }
        public string manifest_type_id { get; set; }
    }

    public class DeclarationChargeDTOList
    {
        //null
    }

    public class DeclarationInvoiceDTOList
    {
        public string invoice_no { get; set; }
        public string invoice_date { get; set; }
        public string incoterms_id { get; set; }
        public decimal? inv_amount { get; set; }
        public string inv_currency_id { get; set; }
        public decimal? fre_amount { get; set; }
        public decimal fre_percentage { get; set; }
        public string fre_currency_id { get; set; }
        public decimal? ins_amount { get; set; }
        public string ins_currency_id { get; set; }
    }

    public class DeclarationItemDTOList
    {
        public string hscode_int { get; set; }
        public string description { get; set; }
        public string country_of_origin_id { get; set; }
        public string cpc_code_int { get; set; }
        public string vehicle_flag { get; set; }
        public int quantity { get; set; }
        public string quantity_uom_id { get; set; }
        public decimal? gross_weight { get; set; }
        public string gross_weight_uom_id { get; set; }
        public decimal? no_of_packages { get; set; }
        public string package_type_id { get; set; }
        public string comm_name_int { get; set; }
        public decimal? net_weight { get; set; }
        public string net_weight_uom_id { get; set; }
        public DeclarationItemValueDTO declarationItemValueDTO { get; set; }
    }

    public class DeclarationItemValueDTO
    {
        public string invoice_no { get; set; }
        public decimal? inv_amt { get; set; }
    }

    public class DeclarationDocumentDTOList
    {
        public string document_code_id { get; set; }
        public string file_content_filename { get; set; }
        public string remarks { get; set; }
        public string file_content_int { get; set; }

    }
}
