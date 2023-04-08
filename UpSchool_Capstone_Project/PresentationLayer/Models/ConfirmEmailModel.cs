﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace PresentationLayer.Models
{
    public class ConfirmEmailModel
    {
        public int UserId { get; set; }
        public string Code { get; set; }
    }
}
