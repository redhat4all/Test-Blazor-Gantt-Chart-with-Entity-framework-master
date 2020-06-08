using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GanttEF.Models
{
    public partial class GanttData
    {
        [Key]
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string Name { get; set; }
        public DateTime? Sdate { get; set; }
        public DateTime? Edate { get; set; }
        public string Progress { get; set; }
        public string Naresh { get; set; }
        
        public int? ParentId { get; set; }


        public DateTime? BaselineStartDate { get; set; }
        public DateTime? BaselineEndDate { get; set; }
        public string Duration { get; set; }
        
        public string Predecessor { get; set; }
        public List<GanttData> SubTasks { get; set; }
        
        public string Notes { get; set; }
        public string TaskType { get; set; }


    }
}
