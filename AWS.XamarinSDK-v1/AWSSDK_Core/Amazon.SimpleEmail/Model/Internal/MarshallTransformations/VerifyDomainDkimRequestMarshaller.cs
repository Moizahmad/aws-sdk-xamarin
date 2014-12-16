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
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleEmail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.SimpleEmail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// VerifyDomainDkim Request Marshaller
    /// </summary>       
    public class VerifyDomainDkimRequestMarshaller : IMarshaller<IRequest, VerifyDomainDkimRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((VerifyDomainDkimRequest)input);
        }
    
        public IRequest Marshall(VerifyDomainDkimRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleEmail");
            request.Parameters.Add("Action", "VerifyDomainDkim");
            request.Parameters.Add("Version", "2010-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetDomain())
                {
                    request.Parameters.Add("Domain", StringUtils.FromString(publicRequest.Domain));
                }
            }
            return request;
        }
    }
}