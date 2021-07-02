using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeBlazorClient.Pages {
    public partial class AboutApp {

        [Parameter]
        public bool ShowClientInfo { get; set; } = true;

        [Parameter]
        public bool ShowBackendInfo { get; set; } = true;

        [Parameter]
        public bool ShowHostingInfo { get; set; } = true;

        [Parameter]
        public bool ShowContainerInfo { get; set; } = true;

        void ToggleClientInfo() {
            ShowClientInfo = !ShowClientInfo;
        }

        void ToggleBackendInfo() {
            ShowBackendInfo = !ShowBackendInfo;
        }

        void ToggleHostingInfo() {
            ShowHostingInfo = !ShowHostingInfo;
        }

        void ToggleContainerInfo() {
            ShowContainerInfo = !ShowContainerInfo;
        }
    }
}
