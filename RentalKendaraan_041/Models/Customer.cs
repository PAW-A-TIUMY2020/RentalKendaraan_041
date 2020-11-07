﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_041.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Peminjaman = new HashSet<Peminjaman>();
        }

        public int IdCustomerr { get; set; }
        [Required(ErrorMessage = "Nama Customer tidak boleh kosong")]
        public string NamaCustomer { get; set; }
        [RegularExpression("^[0-9]*$", ErrorMessage ="Hanya boleh diisi oleh angka")]
        public string Nik { get; set; }
        [Required(ErrorMessage = "Alamat tidak boleh kosong")]
        public string Alamat { get; set; }
        [MinLength(10, ErrorMessage ="No HP minimmal 10 angka")]
        [MaxLength(13, ErrorMessage ="No Hp maksimal 13 angka")]
        public string NoHp { get; set; }
        [Required(ErrorMessage ="Gender tidak boleh kosong")]
        public int? IdGender { get; set; }

        public Gender IdGenderNavigation { get; set; }
        public ICollection<Peminjaman> Peminjaman { get; set; }
    }
}
