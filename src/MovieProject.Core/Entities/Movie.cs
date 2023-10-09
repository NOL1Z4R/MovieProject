using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using MovieProject.Authorization.Users;

namespace MovieProject.Entities;

public class Movie:FullAuditedEntity
{
     // public long UserId { get; set; }
     public string Name { get; set; }
     // public long RateId { get; set; }
     public int Rating { get; set; }
     public string Description { get; set; }
     
     // [ForeignKey(nameof(UserId))] 
     // public User User { get; set; }

     public ICollection<Rate> Rates {get; set; }
     // [ForeignKey(nameof(RateId))] 
     // public Rate Rate { get; set; }
}