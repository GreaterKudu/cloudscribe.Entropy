﻿// Copyright (c) Source Tree Solutions, LLC. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// Author:					Joe Audette
// Created:					2016-11-19
// Last Modified:			2016-11-19
// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cloudscribe.SimpleContactForm.Models
{
    public class ContactForm
    {
        public string Id { get; set; } = "default";
        public string RecipientCsv { get; set; } = string.Empty;

        public bool CopySubmitterEmailOnSubmission { get; set; } = false;
    }
}
