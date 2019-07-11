using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using endoREG_MVC.Models;
using Microsoft.AspNetCore.Identity;

namespace endoREG_MVC.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<ActionItem> ActionItem { get; set; }
        public DbSet<CompliancePlan> CompliancePlan { get; set; }
        public DbSet<ResponsibleParty> ResponsibleParty { get; set; }
        public DbSet<Completion> Completion { get; set; }
        public DbSet<CompletionActionItem> CompletionActionItem { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            modelBuilder.Entity<Completion>()
                .Property(b => b.DateCreated)
                .HasDefaultValueSql("GETDATE()");

            // Restrict deletion of related order when CompletionActionItems entry is removed
            modelBuilder.Entity<Completion>()
                .HasMany(c => c.CompletionActionItems)
                .WithOne(l => l.Completion)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ActionItem>()
                .Property(b => b.DateAssigned)
                .HasDefaultValueSql("GETDATE()");

            // Restrict deletion of related actionItem when CompletionActionItems entry is removed
            modelBuilder.Entity<ActionItem>()
            .HasMany(c => c.CompletionActionItems)
            .WithOne(l => l.ActionItem)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ResponsibleParty>()
                .Property(b => b.DateAssigned)
                .HasDefaultValueSql("GETDATE()");

            ApplicationUser user = new ApplicationUser
            {
                FirstName = "Joe",
                LastName = "Wellman",
                StreetAddress = "123 NewForce Drive",
                UserName = "admin@admin.com",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                Id = "00000000-ffff-ffff-ffff-ffffffffffff"
            };
            var passwordHash = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = passwordHash.HashPassword(user, "Admin8*");
            modelBuilder.Entity<ApplicationUser>().HasData(user);

            modelBuilder.Entity<ResponsibleParty>().HasData(
                new ResponsibleParty()
                {
                    ResponsiblePartyId = 1,
                    UserId = user.Id,
                    NameOrGroup = "Safety Team",
                    NameOrGroupNumber = "001"
                },
                new ResponsibleParty()
                {
                    ResponsiblePartyId = 2,
                    UserId = user.Id,
                    NameOrGroup = "HR Team",
                    NameOrGroupNumber = "002"
                }
            );

            modelBuilder.Entity<CompliancePlan>().HasData(
                new CompliancePlan()
                {
                    CompliancePlanId = 1,
                    Label = "29 CFR 1910 General Industry Compliance"
                },
                new CompliancePlan()
                {
                    CompliancePlanId = 2,
                    Label = "29 CFR Part 1926 Construction Compliance"
                },
                new CompliancePlan()
                {
                    CompliancePlanId = 3,
                    Label = "Responsible Care® Compliance Plan"
                },
                new CompliancePlan()
                {
                    CompliancePlanId = 4,
                    Label = "Human Resource (HR) Services Compliance Plan"
                },
                new CompliancePlan()
                {
                    CompliancePlanId = 5,
                    Label = "Health, Environmental, Safety, and Security (HES&S) Compliance Plan"
                },
                new CompliancePlan()
                {
                    CompliancePlanId = 6,
                    Label = "Industrial Hygiene Compliance Plan"
                },
                new CompliancePlan()
                {
                    CompliancePlanId = 7,
                    Label = "Risk Management Compliance Plan"
                },
                new CompliancePlan()
                {
                    CompliancePlanId = 8,
                    Label = "Workers Compensation Compliance Plan"
                },
                new CompliancePlan()
                {
                    CompliancePlanId = 9,
                    Label = "Quality Assurance / Control Compliance"
                },
                new CompliancePlan()
                {
                    CompliancePlanId = 10,
                    Label = "Employee Training Compliance Plan"
                }
            );

            //    modelBuilder.Entity<ActionItem>().HasData(
            //        new ActionItem()
            //        {
            //            ActionItemId = 1,
            //            CompliancePlanId = 1,
            //            UserId = user.Id,
            //            Description = "Platforms higher than 4ft require protection from falls.",
            //            Title = "General Industry Protection from Falls",
            //            DaysToComplete = 30,
            //            Weight = 5
            //        },
            //        new ActionItem()
            //        {
            //            ActionItemId = 2,
            //            CompliancePlanId = 2,
            //            UserId = user.Id,
            //            Description = "Ladder extensions over levels (exceeding 6ft) require tie-off, 3ft above surface level.",
            //            Title = "Construction Fall Protection",
            //            DaysToComplete = 1,
            //            Weight = 5
            //        },
            //        new ActionItem()
            //        {
            //            ActionItemId = 3,
            //            CompliancePlanId = 3,
            //            UserId = user.Id,
            //            Description = "Fulfillment of ACC’s Responsible Care Third-Party Audit Requirement is a mandatory element of the ACC’s Responsible Care initiative.",
            //            Title = "General",
            //            DaysToComplete = 90,
            //            Weight = 2
            //        },
            //        new ActionItem()
            //        {
            //            ActionItemId = 4,
            //            CompliancePlanId = 3,
            //            UserId = user.Id,
            //            Description = "Employees have not been enrolled in sexual harassment training.",
            //            Title = "Sexual Harassment Education Needed",
            //            DaysToComplete = 45,
            //            Weight = 1
            //        },
            //        new ActionItem()
            //        {
            //            ActionItemId = 5,
            //            CompliancePlanId = 3,
            //            UserId = user.Id,
            //            Description = "Forklift Drivers have not had operational or safety training in 5 years.  Operators are required to have training every 3 years.",
            //            Title = "Forklift Operation",
            //            DaysToComplete = 32,
            //            Weight = 3
            //        }
            //    );

            //    modelBuilder.Entity<Completion>().HasData(
            //    new Completion()
            //    {
            //        CompletionId = 1,
            //        UserId = user.Id,
            //        ResponsiblePartyId = null
            //    }
            //);

            //modelBuilder.Entity<CompletionActionItem>().HasData(
            //    new CompletionActionItem()
            //    {
            //        CompletionActionItemId = 1,
            //        CompletionId = 1,
            //        ActionItemId = 1
            //    }
            //);

            //modelBuilder.Entity<CompletionActionItem>().HasData(
            //    new CompletionActionItem()
            //    {
            //        CompletionActionItemId = 2,
            //        CompletionId = 1,
            //        ActionItemId = 2
            //    }
            //);
        }
    }
}