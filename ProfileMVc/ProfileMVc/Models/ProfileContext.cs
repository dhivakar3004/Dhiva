using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProfileMVc.Models
{  public class ProfileContext:DbContext
    {
        public ProfileContext()
        {

        }
        public ProfileContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Profile> Profiles { get; set; }
     }   
 }

