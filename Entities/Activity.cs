using TrabajoNET.DTOs;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrabajoNET.Entities
{
    [Table("Activities")]
    public class Activity
    {
        [Key]
        [Column("activity_id")]
        public int Id { get; set; }

        [Column("activity_title", TypeName = "VARCHAR(100)")]
        public string Title { get; set; }
        [Column("activity_description", TypeName = "VARCHAR(100)")]
        public string Description { get; set; }
        [Column("activity_Iscompleted")]
        public bool IsCompleted { get; set; }

        public static implicit operator Activity(ActivityRegisterDTO v)
        {
            var activity = new Activity();
            activity.Title = v.Title;
            activity.Description = v.Description;
            return activity;
        }
    }
}