//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Homecare.Models.DataModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    public partial class PatientView
    {

        [DisplayName("Fulde navn")]
        public string patient_name { get; set; }
        public string road_name { get; set; }
        public string number { get; set; }

        [DisplayName("Telefonenr.")]
        public string phone_number { get; set; }
        public string city_name { get; set; }
        public string zipcode { get; set; }
        [DisplayName("CPR-nummer")]
        public string cpr { get; set; }
        public string relative_phonenumber { get; set; }
        public int id_patient { get; set; }
    }
}
