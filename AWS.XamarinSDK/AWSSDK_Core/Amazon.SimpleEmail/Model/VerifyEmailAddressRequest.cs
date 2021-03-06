/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Container for the parameters to the VerifyEmailAddress operation.
    /// Verifies an email address. This action causes a confirmation email message to be 
    ///        sent to the specified address.
    /// 
    ///         <important>The VerifyEmailAddress action is deprecated as of the May 15, 2012
    /// release        of Domain Verification. The VerifyEmailIdentity action is now preferred.</important>
    ///        
    /// <para>
    /// This action is throttled at one request per second.
    /// </para>
    /// </summary>
    public partial class VerifyEmailAddressRequest : AmazonSimpleEmailServiceRequest
    {
        private string _emailAddress;

        /// <summary>
        /// Gets and sets the property EmailAddress. 
        /// <para>
        /// The email address to be verified.
        /// </para>
        /// </summary>
        public string EmailAddress
        {
            get { return this._emailAddress; }
            set { this._emailAddress = value; }
        }

        // Check to see if EmailAddress property is set
        internal bool IsSetEmailAddress()
        {
            return this._emailAddress != null;
        }

    }
}