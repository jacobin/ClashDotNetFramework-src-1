﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashDotNetFramework.Models.GitHubRelease
{
    public class GitHubRelease
    {
        private readonly string _owner;
        private readonly string _repo;

        public GitHubRelease(string owner, string repo)
        {
            _owner = owner;
            _repo = repo;
        }

        public string AllReleaseUrl => $@"https://api.github.com/repos/{_owner}/{_repo}/releases";
    }
}
