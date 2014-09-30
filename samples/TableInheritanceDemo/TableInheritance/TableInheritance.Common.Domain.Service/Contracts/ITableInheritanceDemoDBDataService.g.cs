﻿//------------------------------------------------------------------------------
// <auto-generated>
//   This file was generated by T4 code generator Model2.tt.
//   Any changes made to this file manually may cause incorrect behavior
//   and will be lost next time the file is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using NTier.Common.Domain.Model;
using TableInheritance.Common.Domain.Model.TableInheritanceDemoDB;

namespace TableInheritance.Common.Domain.Service.Contracts
{
    [ServiceContract]
    public partial interface ITableInheritanceDemoDBDataService
    {
        [OperationContract]
        QueryResult<Person> GetPeople(ClientInfo clientInfo, Query query);

        [OperationContract]
        QueryResult<Address> GetAddresses(ClientInfo clientInfo, Query query);

        [OperationContract]
        QueryResult<Demographic> GetDemographics(ClientInfo clientInfo, Query query);

        [OperationContract]
        QueryResult<EmployeeRole> GetEmployeeRoles(ClientInfo clientInfo, Query query);

        [OperationContract]
        [FaultContract(typeof(TableInheritanceDemoDBUpdateFault))]
        [FaultContract(typeof(TableInheritanceDemoDBOptimisticConcurrencyFault))]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        TableInheritanceDemoDBResultSet SubmitChanges(ClientInfo clientInfo, TableInheritanceDemoDBChangeSet changeSet);
    }
}
