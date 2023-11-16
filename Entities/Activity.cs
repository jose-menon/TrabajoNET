using TrabajoNET.DTOs;
using TrabajoNET.Helpers;
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

        public static implicit operator User(ActivityRegisterDTO v)
        {
            var activity = new Activity();
            activity.title = v.Title;
            activity.description = v.Description;
            return user;
        }
    }
}