using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using MovieProject.Authorization.Users;

namespace MovieProject.Entities;

public class Movie:FullAuditedEntity
{
     public long UserId { get; set; }
     public long Id { get; set; }
     public int Rate { get; set; }
     public string Description { get; set; }
     
     [ForeignKey(nameof(UserId))] 
     public User User { get; set; }
}