// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// Information about the compute node on which a task ran.
    /// </summary>
    public partial class ComputeNodeInformation
    {
        /// <summary>
        /// Initializes a new instance of the ComputeNodeInformation class.
        /// </summary>
        public ComputeNodeInformation() { }

        /// <summary>
        /// Initializes a new instance of the ComputeNodeInformation class.
        /// </summary>
        /// <param name="affinityId">An identifier for the compute node on
        /// which the task ran, which can be passed when adding a task to
        /// request that the task be scheduled close to this compute
        /// node.</param>
        /// <param name="nodeUrl">The URL of the node on which the task ran.
        /// </param>
        /// <param name="poolId">The id of the pool on which the task
        /// ran.</param>
        /// <param name="nodeId">The id of the node on which the task
        /// ran.</param>
        /// <param name="taskRootDirectory">The root directory of the task on
        /// the compute node.</param>
        /// <param name="taskRootDirectoryUrl">The URL to the root directory
        /// of the task on the compute node.</param>
        public ComputeNodeInformation(string affinityId = default(string), string nodeUrl = default(string), string poolId = default(string), string nodeId = default(string), string taskRootDirectory = default(string), string taskRootDirectoryUrl = default(string))
        {
            AffinityId = affinityId;
            NodeUrl = nodeUrl;
            PoolId = poolId;
            NodeId = nodeId;
            TaskRootDirectory = taskRootDirectory;
            TaskRootDirectoryUrl = taskRootDirectoryUrl;
        }

        /// <summary>
        /// Gets or sets an identifier for the compute node on which the task
        /// ran, which can be passed when adding a task to request that the
        /// task be scheduled close to this compute node.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "affinityId")]
        public string AffinityId { get; set; }

        /// <summary>
        /// Gets or sets the URL of the node on which the task ran.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "nodeUrl")]
        public string NodeUrl { get; set; }

        /// <summary>
        /// Gets or sets the id of the pool on which the task ran.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "poolId")]
        public string PoolId { get; set; }

        /// <summary>
        /// Gets or sets the id of the node on which the task ran.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "nodeId")]
        public string NodeId { get; set; }

        /// <summary>
        /// Gets or sets the root directory of the task on the compute node.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "taskRootDirectory")]
        public string TaskRootDirectory { get; set; }

        /// <summary>
        /// Gets or sets the URL to the root directory of the task on the
        /// compute node.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "taskRootDirectoryUrl")]
        public string TaskRootDirectoryUrl { get; set; }

    }
}
