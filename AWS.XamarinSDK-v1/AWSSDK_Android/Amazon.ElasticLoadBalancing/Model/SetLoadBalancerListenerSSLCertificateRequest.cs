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
 * Do not modify this file. This file is generated from the elasticloadbalancing-2012-06-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// Container for the parameters to the SetLoadBalancerListenerSSLCertificate operation.
    /// Sets the certificate that terminates the specified listener's SSL connections. The
    /// specified certificate replaces any prior certificate that was used on the same load
    /// balancer and port. 
    /// 
    ///  
    /// <para>
    /// For more information on updating your SSL certificate, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/US_UpdatingLoadBalancerSSL.html">Updating
    /// an SSL Certificate for a Load Balancer</a> in the <i>Elastic Load Balancing Developer
    /// Guide</i>.
    /// </para>
    /// </summary>
    public partial class SetLoadBalancerListenerSSLCertificateRequest : AmazonElasticLoadBalancingRequest
    {
        private string _loadBalancerName;
        private int? _loadBalancerPort;
        private string _sSLCertificateId;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public SetLoadBalancerListenerSSLCertificateRequest() { }

        /// <summary>
        /// Instantiates SetLoadBalancerListenerSSLCertificateRequest with the parameterized properties
        /// </summary>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="loadBalancerPort"> The port that uses the specified SSL certificate. </param>
        /// <param name="sslCertificateId"> The Amazon Resource Number (ARN) of the SSL certificate chain to use. For more information on SSL certificates, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/ManagingServerCerts.html"> Managing Server Certificates</a> in the <i>AWS Identity and Access Management User Guide</i>.</param>
        public SetLoadBalancerListenerSSLCertificateRequest(string loadBalancerName, int loadBalancerPort, string sslCertificateId)
        {
            _loadBalancerName = loadBalancerName;
            _loadBalancerPort = loadBalancerPort;
            _sSLCertificateId = sslCertificateId;
        }

        /// <summary>
        /// Gets and sets the property LoadBalancerName. 
        /// <para>
        ///  The name of the load balancer. 
        /// </para>
        /// </summary>
        public string LoadBalancerName
        {
            get { return this._loadBalancerName; }
            set { this._loadBalancerName = value; }
        }

        // Check to see if LoadBalancerName property is set
        internal bool IsSetLoadBalancerName()
        {
            return this._loadBalancerName != null;
        }

        /// <summary>
        /// Gets and sets the property LoadBalancerPort. 
        /// <para>
        ///  The port that uses the specified SSL certificate. 
        /// </para>
        /// </summary>
        public int LoadBalancerPort
        {
            get { return this._loadBalancerPort.GetValueOrDefault(); }
            set { this._loadBalancerPort = value; }
        }

        // Check to see if LoadBalancerPort property is set
        internal bool IsSetLoadBalancerPort()
        {
            return this._loadBalancerPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SSLCertificateId. 
        /// <para>
        ///  The Amazon Resource Number (ARN) of the SSL certificate chain to use. For more information
        /// on SSL certificates, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/ManagingServerCerts.html">
        /// Managing Server Certificates</a> in the <i>AWS Identity and Access Management User
        /// Guide</i>.
        /// </para>
        /// </summary>
        public string SSLCertificateId
        {
            get { return this._sSLCertificateId; }
            set { this._sSLCertificateId = value; }
        }

        // Check to see if SSLCertificateId property is set
        internal bool IsSetSSLCertificateId()
        {
            return this._sSLCertificateId != null;
        }

    }
}