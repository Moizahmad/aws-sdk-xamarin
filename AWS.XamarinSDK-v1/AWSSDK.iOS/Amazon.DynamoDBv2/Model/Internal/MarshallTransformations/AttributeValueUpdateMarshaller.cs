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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DynamoDBv2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AttributeValueUpdate Marshaller
    /// </summary>       
    public class AttributeValueUpdateMarshaller : IRequestMarshaller<AttributeValueUpdate, JsonMarshallerContext> 
    {
        public void Marshall(AttributeValueUpdate requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAction())
            {
                context.Writer.WritePropertyName("Action");
                context.Writer.Write(requestObject.Action);
            }

            if(requestObject.IsSetValue())
            {
                context.Writer.WritePropertyName("Value");
                context.Writer.WriteObjectStart();

                var marshaller = AttributeValueMarshaller.Instance;
                marshaller.Marshall(requestObject.Value, context);

                context.Writer.WriteObjectEnd();
            }

        }

        public readonly static AttributeValueUpdateMarshaller Instance = new AttributeValueUpdateMarshaller();

    }
}