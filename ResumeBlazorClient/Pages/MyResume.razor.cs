using ResumeCore.Entity.Models;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components;
using ResumeCore.Entity;
using System.Linq;

namespace ResumeBlazorClient.Pages {
    public partial class MyResume {
        public Resume Resume { get; set; }
        public bool HasSkills { get; set; }
        public bool HasProfileStatement { get; set; }
        public bool HasEducationHistory { get; set; }
        public bool HasWorkHistory { get; set; }

        private static string JustinsResumeId = "dbbab80d-fe68-40df-9ab6-7043777c3da4";

        [Inject]
        public HttpClient Http { get; set; }

        private async Task InitializeResume() {
            var ResumeEntity = await Http.GetFromJsonAsync<ResumeEntity>($"https://localhost:5011/resume/{JustinsResumeId}");
            Resume = ResumeEntity.Resume;
            HasSkills = Resume.SkillGroups != null && Resume.SkillGroups.ToList().Count() > 0;
            HasProfileStatement = Resume.ObjectiveStatement != null && Resume.ObjectiveStatement.ToList().Count() > 0;
            HasEducationHistory = Resume.EducationHistory != null && Resume.EducationHistory.ToList().Count() > 0;
            HasWorkHistory = Resume.WorkHistory != null && Resume.WorkHistory.ToList().Count() > 0;
        }

        protected override async Task OnInitializedAsync() {
            await InitializeResume();
        }
    }
}
