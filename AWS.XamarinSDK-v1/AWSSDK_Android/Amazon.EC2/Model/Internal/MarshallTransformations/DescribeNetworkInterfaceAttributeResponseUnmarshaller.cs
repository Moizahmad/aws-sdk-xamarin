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
 * Do not modify this file. This file is generated from the ec2-2014-06-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeNetworkInterfaceAttribute operation
    /// </summary>  
    public class DescribeNetworkInterfaceAttributeResponseUnmarshaller : EC2ResponseUnmarshaller
    {
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            DescribeNetworkInterfaceAttributeResponse response = new DescribeNetworkInterfaceAttributeResponse();

            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
               targetDepth = 2;

            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {

                    if (context.TestExpression("attachment", targetDepth))
                    {
                        var unmarshaller = NetworkInterfaceAttachmentUnmarshaller.Instance;
                        response.Attachment = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("description/value", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Description = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("groupSet/item", targetDepth))
                    {
                        var unmarshaller = GroupIdentifierUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        response.Groups.Add(item);
                        continue;
                    }
                    if (context.TestExpression("networkInterfaceId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.NetworkInterfaceId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("sourceDestCheck/value", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        response.SourceDestCheck = unmarshaller.Unmarshall(context);
                        continue;
                    }
                } 
            }

            return response;
        }

        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = ErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            return new AmazonEC2Exception(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }
        private static DescribeNetworkInterfaceAttributeResponseUnmarshaller _instance = new DescribeNetworkInterfaceAttributeResponseUnmarshaller();        

        internal static DescribeNetworkInterfaceAttributeResponseUnmarshaller GetInstance()
        {
            return _instance;
        }
        public static DescribeNetworkInterfaceAttributeResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}