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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
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
    /// Response Unmarshaller for DhcpConfiguration Object
    /// </summary>  
    public class DhcpConfigurationUnmarshaller : IUnmarshaller<DhcpConfiguration, XmlUnmarshallerContext>, IUnmarshaller<DhcpConfiguration, JsonUnmarshallerContext>
    {
        public DhcpConfiguration Unmarshall(XmlUnmarshallerContext context)
        {
            DhcpConfiguration unmarshalledObject = new DhcpConfiguration();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("key", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Key = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("valueSet/item/value", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Values.Add(item);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }

            return unmarshalledObject;
        }

        public DhcpConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static DhcpConfigurationUnmarshaller _instance = new DhcpConfigurationUnmarshaller();        

        public static DhcpConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}