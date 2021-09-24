using System;
using System.Text.Json;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiService.Models
{
    public class AnswerManagement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? ans_id { get; set; }

        [Column(TypeName = "varchar(500)")]
        public string ans_cont { get; set; }

        public int qst_id { get; set; }

        public int user_id { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string img_url { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string ref_url { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string rating { get; set; }

        [Column(TypeName = "char(1)")]
        public bool isActive { get; set; }

        public DateTime createDate { get; set; }
        public DateTime updateDate { get; set; }

        public static void Copy(ref AnswerManagement model, ref AnswerManagement copy)
        {
            model.ans_id = copy.ans_id;
            model.ans_cont = copy.ans_cont;
            model.qst_id = copy.qst_id;
            model.user_id = copy.user_id;
            model.img_url = copy.img_url;
            model.ref_url = copy.ref_url;
            model.rating = copy.rating;
            model.isActive = copy.isActive;
            model.createDate = copy.createDate;
            model.updateDate = copy.updateDate;
        }
    }
}