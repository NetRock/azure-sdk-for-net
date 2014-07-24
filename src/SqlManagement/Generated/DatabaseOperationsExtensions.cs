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
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Management.Sql;
using Microsoft.WindowsAzure.Management.Sql.Models;

namespace Microsoft.WindowsAzure
{
    /// <summary>
    /// This is the main client class for interacting with the Azure SQL
    /// Database REST APIs.
    /// </summary>
    public static partial class DatabaseOperationsExtensions
    {
        /// <summary>
        /// Creates a database in an Azure SQL Database Server.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Sql.IDatabaseOperations.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server where the
        /// database will be created.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters for the create database operation.
        /// </param>
        /// <returns>
        /// Represents the response to a create database request from the
        /// service.
        /// </returns>
        public static DatabaseCreateResponse Create(this IDatabaseOperations operations, string serverName, DatabaseCreateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDatabaseOperations)s).CreateAsync(serverName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Creates a database in an Azure SQL Database Server.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Sql.IDatabaseOperations.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server where the
        /// database will be created.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters for the create database operation.
        /// </param>
        /// <returns>
        /// Represents the response to a create database request from the
        /// service.
        /// </returns>
        public static Task<DatabaseCreateResponse> CreateAsync(this IDatabaseOperations operations, string serverName, DatabaseCreateParameters parameters)
        {
            return operations.CreateAsync(serverName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Drops a database from an Azure SQL Database Server.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Sql.IDatabaseOperations.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server on which the
        /// database is hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Database to be deleted.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static OperationResponse Delete(this IDatabaseOperations operations, string serverName, string databaseName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDatabaseOperations)s).DeleteAsync(serverName, databaseName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Drops a database from an Azure SQL Database Server.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Sql.IDatabaseOperations.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server on which the
        /// database is hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Database to be deleted.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<OperationResponse> DeleteAsync(this IDatabaseOperations operations, string serverName, string databaseName)
        {
            return operations.DeleteAsync(serverName, databaseName, CancellationToken.None);
        }
        
        /// <summary>
        /// Returns information about an Azure SQL Database.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Sql.IDatabaseOperations.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server on which the
        /// database is hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Database to be retrieved.
        /// </param>
        /// <returns>
        /// Contains the response to a Get Database request.
        /// </returns>
        public static DatabaseGetResponse Get(this IDatabaseOperations operations, string serverName, string databaseName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDatabaseOperations)s).GetAsync(serverName, databaseName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Returns information about an Azure SQL Database.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Sql.IDatabaseOperations.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server on which the
        /// database is hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Database to be retrieved.
        /// </param>
        /// <returns>
        /// Contains the response to a Get Database request.
        /// </returns>
        public static Task<DatabaseGetResponse> GetAsync(this IDatabaseOperations operations, string serverName, string databaseName)
        {
            return operations.GetAsync(serverName, databaseName, CancellationToken.None);
        }
        
        /// <summary>
        /// Returns information about an Azure SQL Database event logs.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Sql.IDatabaseOperations.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server on which the
        /// database is hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Database to be retrieved.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters for the Get Database Event Logs operation.
        /// </param>
        /// <returns>
        /// Contains the response to a Get Database Event Logs request.
        /// </returns>
        public static DatabaseGetEventLogsResponse GetEventLogs(this IDatabaseOperations operations, string serverName, string databaseName, DatabaseGetEventLogsParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDatabaseOperations)s).GetEventLogsAsync(serverName, databaseName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Returns information about an Azure SQL Database event logs.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Sql.IDatabaseOperations.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server on which the
        /// database is hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Database to be retrieved.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters for the Get Database Event Logs operation.
        /// </param>
        /// <returns>
        /// Contains the response to a Get Database Event Logs request.
        /// </returns>
        public static Task<DatabaseGetEventLogsResponse> GetEventLogsAsync(this IDatabaseOperations operations, string serverName, string databaseName, DatabaseGetEventLogsParameters parameters)
        {
            return operations.GetEventLogsAsync(serverName, databaseName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Returns a collection of Azure SQL Databases.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Sql.IDatabaseOperations.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server from which to
        /// retrieve the database.
        /// </param>
        /// <returns>
        /// Contains a collection of databases for a given Azure SQL Database
        /// Server.
        /// </returns>
        public static DatabaseListResponse List(this IDatabaseOperations operations, string serverName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDatabaseOperations)s).ListAsync(serverName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Returns a collection of Azure SQL Databases.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Sql.IDatabaseOperations.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server from which to
        /// retrieve the database.
        /// </param>
        /// <returns>
        /// Contains a collection of databases for a given Azure SQL Database
        /// Server.
        /// </returns>
        public static Task<DatabaseListResponse> ListAsync(this IDatabaseOperations operations, string serverName)
        {
            return operations.ListAsync(serverName, CancellationToken.None);
        }
        
        /// <summary>
        /// Updates the properties of an Azure SQL Database.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Sql.IDatabaseOperations.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server where the
        /// database is hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Database to be updated.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters for the Update Database operation.
        /// </param>
        /// <returns>
        /// Contains the response from a request to Update Database.
        /// </returns>
        public static DatabaseUpdateResponse Update(this IDatabaseOperations operations, string serverName, string databaseName, DatabaseUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDatabaseOperations)s).UpdateAsync(serverName, databaseName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Updates the properties of an Azure SQL Database.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Sql.IDatabaseOperations.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server where the
        /// database is hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Database to be updated.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters for the Update Database operation.
        /// </param>
        /// <returns>
        /// Contains the response from a request to Update Database.
        /// </returns>
        public static Task<DatabaseUpdateResponse> UpdateAsync(this IDatabaseOperations operations, string serverName, string databaseName, DatabaseUpdateParameters parameters)
        {
            return operations.UpdateAsync(serverName, databaseName, parameters, CancellationToken.None);
        }
    }
}
