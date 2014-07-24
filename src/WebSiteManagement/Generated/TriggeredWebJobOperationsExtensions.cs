// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.WebSitesExtensions;
using Microsoft.WindowsAzure.WebSitesExtensions.Models;

namespace Microsoft.WindowsAzure
{
    /// <summary>
    /// The websites extensions client manages the web sites deployments, web
    /// jobs and other extensions.
    /// </summary>
    public static partial class TriggeredWebJobOperationsExtensions
    {
        /// <summary>
        /// Delete a triggered WebJob.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.ITriggeredWebJobOperations.
        /// </param>
        /// <param name='jobName'>
        /// Required. The triggered WebJob name.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static OperationResponse Delete(this ITriggeredWebJobOperations operations, string jobName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ITriggeredWebJobOperations)s).DeleteAsync(jobName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Delete a triggered WebJob.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.ITriggeredWebJobOperations.
        /// </param>
        /// <param name='jobName'>
        /// Required. The triggered WebJob name.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<OperationResponse> DeleteAsync(this ITriggeredWebJobOperations operations, string jobName)
        {
            return operations.DeleteAsync(jobName, CancellationToken.None);
        }
        
        /// <summary>
        /// Get a triggered web job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.ITriggeredWebJobOperations.
        /// </param>
        /// <param name='jobName'>
        /// Required. The triggered WebJob name.
        /// </param>
        /// <returns>
        /// The get triggered WebJob Operation Response.
        /// </returns>
        public static TriggeredWebJobGetResponse Get(this ITriggeredWebJobOperations operations, string jobName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ITriggeredWebJobOperations)s).GetAsync(jobName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get a triggered web job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.ITriggeredWebJobOperations.
        /// </param>
        /// <param name='jobName'>
        /// Required. The triggered WebJob name.
        /// </param>
        /// <returns>
        /// The get triggered WebJob Operation Response.
        /// </returns>
        public static Task<TriggeredWebJobGetResponse> GetAsync(this ITriggeredWebJobOperations operations, string jobName)
        {
            return operations.GetAsync(jobName, CancellationToken.None);
        }
        
        /// <summary>
        /// Get a web job run.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.ITriggeredWebJobOperations.
        /// </param>
        /// <param name='jobName'>
        /// Required. The triggered WebJob name.
        /// </param>
        /// <param name='jobRunId'>
        /// Required. The triggered WebJob run identifier.
        /// </param>
        /// <returns>
        /// The get triggered WebJob Run operation response.
        /// </returns>
        public static TriggeredWebJobGetRunResponse GetRun(this ITriggeredWebJobOperations operations, string jobName, string jobRunId)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ITriggeredWebJobOperations)s).GetRunAsync(jobName, jobRunId);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get a web job run.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.ITriggeredWebJobOperations.
        /// </param>
        /// <param name='jobName'>
        /// Required. The triggered WebJob name.
        /// </param>
        /// <param name='jobRunId'>
        /// Required. The triggered WebJob run identifier.
        /// </param>
        /// <returns>
        /// The get triggered WebJob Run operation response.
        /// </returns>
        public static Task<TriggeredWebJobGetRunResponse> GetRunAsync(this ITriggeredWebJobOperations operations, string jobName, string jobRunId)
        {
            return operations.GetRunAsync(jobName, jobRunId, CancellationToken.None);
        }
        
        /// <summary>
        /// Get the settings of a triggered WebJob.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.ITriggeredWebJobOperations.
        /// </param>
        /// <param name='jobName'>
        /// Required. The triggered WebJob name.
        /// </param>
        /// <returns>
        /// The triggered WebJob settings operation response.
        /// </returns>
        public static TriggeredWebJobSettingsResponse GetSettings(this ITriggeredWebJobOperations operations, string jobName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ITriggeredWebJobOperations)s).GetSettingsAsync(jobName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get the settings of a triggered WebJob.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.ITriggeredWebJobOperations.
        /// </param>
        /// <param name='jobName'>
        /// Required. The triggered WebJob name.
        /// </param>
        /// <returns>
        /// The triggered WebJob settings operation response.
        /// </returns>
        public static Task<TriggeredWebJobSettingsResponse> GetSettingsAsync(this ITriggeredWebJobOperations operations, string jobName)
        {
            return operations.GetSettingsAsync(jobName, CancellationToken.None);
        }
        
        /// <summary>
        /// List the triggered WebJobs.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.ITriggeredWebJobOperations.
        /// </param>
        /// <returns>
        /// The list of triggered WebJobs operation response.
        /// </returns>
        public static TriggeredWebJobListResponse List(this ITriggeredWebJobOperations operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ITriggeredWebJobOperations)s).ListAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// List the triggered WebJobs.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.ITriggeredWebJobOperations.
        /// </param>
        /// <returns>
        /// The list of triggered WebJobs operation response.
        /// </returns>
        public static Task<TriggeredWebJobListResponse> ListAsync(this ITriggeredWebJobOperations operations)
        {
            return operations.ListAsync(CancellationToken.None);
        }
        
        /// <summary>
        /// List the triggered WebJob runs.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.ITriggeredWebJobOperations.
        /// </param>
        /// <param name='jobName'>
        /// Required. The triggered WebJob name.
        /// </param>
        /// <returns>
        /// The triggered WebJob run list operation response.
        /// </returns>
        public static TriggeredWebJobRunListResponse ListRuns(this ITriggeredWebJobOperations operations, string jobName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ITriggeredWebJobOperations)s).ListRunsAsync(jobName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// List the triggered WebJob runs.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.ITriggeredWebJobOperations.
        /// </param>
        /// <param name='jobName'>
        /// Required. The triggered WebJob name.
        /// </param>
        /// <returns>
        /// The triggered WebJob run list operation response.
        /// </returns>
        public static Task<TriggeredWebJobRunListResponse> ListRunsAsync(this ITriggeredWebJobOperations operations, string jobName)
        {
            return operations.ListRunsAsync(jobName, CancellationToken.None);
        }
        
        /// <summary>
        /// Run a triggered WebJob.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.ITriggeredWebJobOperations.
        /// </param>
        /// <param name='jobName'>
        /// Required. The triggered WebJob name.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static OperationResponse Run(this ITriggeredWebJobOperations operations, string jobName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ITriggeredWebJobOperations)s).RunAsync(jobName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Run a triggered WebJob.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.ITriggeredWebJobOperations.
        /// </param>
        /// <param name='jobName'>
        /// Required. The triggered WebJob name.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<OperationResponse> RunAsync(this ITriggeredWebJobOperations operations, string jobName)
        {
            return operations.RunAsync(jobName, CancellationToken.None);
        }
        
        /// <summary>
        /// Set the settings of a triggered WebJob (will replace the current
        /// settings of the WebJob).
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.ITriggeredWebJobOperations.
        /// </param>
        /// <param name='jobName'>
        /// Required. The triggered WebJob name.
        /// </param>
        /// <param name='settings'>
        /// Required. The triggered WebJob settings.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static OperationResponse SetSettings(this ITriggeredWebJobOperations operations, string jobName, TriggeredWebJobSettingsUpdateParameters settings)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ITriggeredWebJobOperations)s).SetSettingsAsync(jobName, settings);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Set the settings of a triggered WebJob (will replace the current
        /// settings of the WebJob).
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.ITriggeredWebJobOperations.
        /// </param>
        /// <param name='jobName'>
        /// Required. The triggered WebJob name.
        /// </param>
        /// <param name='settings'>
        /// Required. The triggered WebJob settings.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<OperationResponse> SetSettingsAsync(this ITriggeredWebJobOperations operations, string jobName, TriggeredWebJobSettingsUpdateParameters settings)
        {
            return operations.SetSettingsAsync(jobName, settings, CancellationToken.None);
        }
        
        /// <summary>
        /// Create or replace a triggered WebJob with a script file (.exe,
        /// .bat, .php, .js...).
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.ITriggeredWebJobOperations.
        /// </param>
        /// <param name='jobName'>
        /// Required. The triggered WebJob name.
        /// </param>
        /// <param name='fileName'>
        /// Required. The file name.
        /// </param>
        /// <param name='jobContent'>
        /// Required. The file content.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static OperationResponse UploadFile(this ITriggeredWebJobOperations operations, string jobName, string fileName, Stream jobContent)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ITriggeredWebJobOperations)s).UploadFileAsync(jobName, fileName, jobContent);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Create or replace a triggered WebJob with a script file (.exe,
        /// .bat, .php, .js...).
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.ITriggeredWebJobOperations.
        /// </param>
        /// <param name='jobName'>
        /// Required. The triggered WebJob name.
        /// </param>
        /// <param name='fileName'>
        /// Required. The file name.
        /// </param>
        /// <param name='jobContent'>
        /// Required. The file content.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<OperationResponse> UploadFileAsync(this ITriggeredWebJobOperations operations, string jobName, string fileName, Stream jobContent)
        {
            return operations.UploadFileAsync(jobName, fileName, jobContent, CancellationToken.None);
        }
        
        /// <summary>
        /// Create or replace a triggered WebJob with a zip file (containing
        /// the WebJob binaries).
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.ITriggeredWebJobOperations.
        /// </param>
        /// <param name='jobName'>
        /// Required. The triggered WebJob name.
        /// </param>
        /// <param name='fileName'>
        /// Required. The zip file name.
        /// </param>
        /// <param name='jobContent'>
        /// Required. The zip file content.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static OperationResponse UploadZip(this ITriggeredWebJobOperations operations, string jobName, string fileName, Stream jobContent)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ITriggeredWebJobOperations)s).UploadZipAsync(jobName, fileName, jobContent);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Create or replace a triggered WebJob with a zip file (containing
        /// the WebJob binaries).
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.ITriggeredWebJobOperations.
        /// </param>
        /// <param name='jobName'>
        /// Required. The triggered WebJob name.
        /// </param>
        /// <param name='fileName'>
        /// Required. The zip file name.
        /// </param>
        /// <param name='jobContent'>
        /// Required. The zip file content.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<OperationResponse> UploadZipAsync(this ITriggeredWebJobOperations operations, string jobName, string fileName, Stream jobContent)
        {
            return operations.UploadZipAsync(jobName, fileName, jobContent, CancellationToken.None);
        }
    }
}
