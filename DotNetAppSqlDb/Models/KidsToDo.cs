using System;
using System.ComponentModel.DataAnnotations;

namespace DotNetAppSqlDb.Models
{
    public class KidsTodo
    {
        public int ID { get; set; }
        public string Description { get; set; }

        [Display(Name = "Created Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "Up By 550")]
        public bool UpBy550 { get; set; }

        public bool GodSpokeToMyHeart { get; set; }

        public bool JohnWentRun { get; set; }

        public bool JamesWentRun { get; set; }

        public bool PhilipWentRun { get; set; }

        public bool PhilipDidWeights { get; set; }

        public bool PhilipDid100WordsInMorning { get; set; }

        public bool PhilipDid1000Words { get; set; }

        public bool TwinsFightSchool { get; set; }

        public bool James100WordsStudy { get; set; }

        public bool John100WordsStudy { get; set; }
        public bool James5SkillsIXL { get; set; }

        public bool Hannah10SkillsIXL { get; set; }

        public bool HannahPiano { get; set; }

        public bool JamesRecord1PiecePiano { get; set; }

        public bool JohnRecord1PiecePiano { get; set; }

        public bool JamesRecordPianoScale130 { get; set; }

        public bool JohnRecordPianoScale130 { get; set; }

        public int? UserID { get; set; }

        public virtual User User { get; set; }


    }

}