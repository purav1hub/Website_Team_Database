using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GECPATAN_FACULTY_PORTAL.Models;
[Table("CampusCommittees")]
public partial class CampusCommittee
{
    [Key]
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? TitleImage { get; set; }

    public string? About { get; set; }

    public string? Measures { get; set; }

    [Column("Measure_Image")]
    public string? MeasureImage { get; set; }

    public string? SubObjImg { get; set; }

    public string? BulletPointsImg { get; set; }

    public string? PageFlyer { get; set; }

    public string? Tagline { get; set; }

    [Column(" BlogLink")]
    public string? BlogLink { get; set; }

    [Column(" Link")]
    public string? Link { get; set; }

    [Column(" ShowDocument")]
    public byte? ShowDocument { get; set; }

    public byte? TableView { get; set; }

    [Column(" IsDeleted")]
    public byte? IsDeleted { get; set; }

    [Column(" CreatedDate", TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column(" CreatedDateInt")]
    public long? CreatedDateInt { get; set; }

    [Column(" UpdatedDate", TypeName = "datetime")]
    public DateTime? UpdatedDate { get; set; }

    public long? UpdatedDateInt { get; set; }
}
