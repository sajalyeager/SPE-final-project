Imports System
Imports System.Threading.Tasks
Imports System.Collections.Generic
Imports System.Numerics
Imports Nethereum.Hex.HexTypes
Imports Nethereum.ABI.FunctionEncoding.Attributes
Imports Nethereum.Web3
Imports Nethereum.RPC.Eth.DTOs
Imports Nethereum.Contracts.CQS
Imports Nethereum.Contracts.ContractHandlers
Imports Nethereum.Contracts
Imports System.Threading
Imports SPEFinalProject.Contracts.Model.ContractDefinition
Namespace SPEFinalProject.Contracts.Model


    Public Partial Class ModelService
    
    
        Public Shared Function DeployContractAndWaitForReceiptAsync(ByVal web3 As Nethereum.Web3.Web3, ByVal modelDeployment As ModelDeployment, ByVal Optional cancellationTokenSource As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return web3.Eth.GetContractDeploymentHandler(Of ModelDeployment)().SendRequestAndWaitForReceiptAsync(modelDeployment, cancellationTokenSource)
        
        End Function
         Public Shared Function DeployContractAsync(ByVal web3 As Nethereum.Web3.Web3, ByVal modelDeployment As ModelDeployment) As Task(Of String)
        
            Return web3.Eth.GetContractDeploymentHandler(Of ModelDeployment)().SendRequestAsync(modelDeployment)
        
        End Function
        Public Shared Async Function DeployContractAndGetServiceAsync(ByVal web3 As Nethereum.Web3.Web3, ByVal modelDeployment As ModelDeployment, ByVal Optional cancellationTokenSource As CancellationTokenSource = Nothing) As Task(Of ModelService)
        
            Dim receipt = Await DeployContractAndWaitForReceiptAsync(web3, modelDeployment, cancellationTokenSource)
            Return New ModelService(web3, receipt.ContractAddress)
        
        End Function
    
        Protected Property Web3 As Nethereum.Web3.Web3
        
        Public Property ContractHandler As ContractHandler
        
        Public Sub New(ByVal web3 As Nethereum.Web3.Web3, ByVal contractAddress As String)
            Web3 = web3
            ContractHandler = web3.Eth.GetContractHandler(contractAddress)
        End Sub
    
        Public Function ServiceProvidersQueryAsync(ByVal serviceProvidersFunction As ServiceProvidersFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of ServiceProvidersOutputDTO)
        
            Return ContractHandler.QueryDeserializingToObjectAsync(Of ServiceProvidersFunction, ServiceProvidersOutputDTO)(serviceProvidersFunction, blockParameter)
        
        End Function

        
        Public Function ServiceProvidersQueryAsync(ByVal [returnValue1] As String, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of ServiceProvidersOutputDTO)
        
            Dim serviceProvidersFunction = New ServiceProvidersFunction()
                serviceProvidersFunction.ReturnValue1 = [returnValue1]
            
            Return ContractHandler.QueryDeserializingToObjectAsync(Of ServiceProvidersFunction, ServiceProvidersOutputDTO)(serviceProvidersFunction, blockParameter)
        
        End Function


        Public Function UsersQueryAsync(ByVal usersFunction As UsersFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of UsersOutputDTO)
        
            Return ContractHandler.QueryDeserializingToObjectAsync(Of UsersFunction, UsersOutputDTO)(usersFunction, blockParameter)
        
        End Function

        
        Public Function UsersQueryAsync(ByVal [returnValue1] As String, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of UsersOutputDTO)
        
            Dim usersFunction = New UsersFunction()
                usersFunction.ReturnValue1 = [returnValue1]
            
            Return ContractHandler.QueryDeserializingToObjectAsync(Of UsersFunction, UsersOutputDTO)(usersFunction, blockParameter)
        
        End Function


        Public Function AddServiceProviderRequestAsync(ByVal addServiceProviderFunction As AddServiceProviderFunction) As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of AddServiceProviderFunction)(addServiceProviderFunction)
        
        End Function

        Public Function AddServiceProviderRequestAndWaitForReceiptAsync(ByVal addServiceProviderFunction As AddServiceProviderFunction, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of AddServiceProviderFunction)(addServiceProviderFunction, cancellationToken)
        
        End Function

        
        Public Function AddServiceProviderRequestAsync(ByVal [service_type] As BigInteger, ByVal [name] As String, ByVal [location] As String, ByVal [service] As String, ByVal [email] As String, ByVal [phone] As String, ByVal [charges] As BigInteger) As Task(Of String)
        
            Dim addServiceProviderFunction = New AddServiceProviderFunction()
                addServiceProviderFunction.Service_type = [service_type]
                addServiceProviderFunction.Name = [name]
                addServiceProviderFunction.Location = [location]
                addServiceProviderFunction.Service = [service]
                addServiceProviderFunction.Email = [email]
                addServiceProviderFunction.Phone = [phone]
                addServiceProviderFunction.Charges = [charges]
            
            Return ContractHandler.SendRequestAsync(Of AddServiceProviderFunction)(addServiceProviderFunction)
        
        End Function

        
        Public Function AddServiceProviderRequestAndWaitForReceiptAsync(ByVal [service_type] As BigInteger, ByVal [name] As String, ByVal [location] As String, ByVal [service] As String, ByVal [email] As String, ByVal [phone] As String, ByVal [charges] As BigInteger, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Dim addServiceProviderFunction = New AddServiceProviderFunction()
                addServiceProviderFunction.Service_type = [service_type]
                addServiceProviderFunction.Name = [name]
                addServiceProviderFunction.Location = [location]
                addServiceProviderFunction.Service = [service]
                addServiceProviderFunction.Email = [email]
                addServiceProviderFunction.Phone = [phone]
                addServiceProviderFunction.Charges = [charges]
            
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of AddServiceProviderFunction)(addServiceProviderFunction, cancellationToken)
        
        End Function
        Public Function AddUserRequestAsync(ByVal addUserFunction As AddUserFunction) As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of AddUserFunction)(addUserFunction)
        
        End Function

        Public Function AddUserRequestAndWaitForReceiptAsync(ByVal addUserFunction As AddUserFunction, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of AddUserFunction)(addUserFunction, cancellationToken)
        
        End Function

        
        Public Function AddUserRequestAsync(ByVal [name] As String, ByVal [location] As String, ByVal [email] As String, ByVal [phone] As String) As Task(Of String)
        
            Dim addUserFunction = New AddUserFunction()
                addUserFunction.Name = [name]
                addUserFunction.Location = [location]
                addUserFunction.Email = [email]
                addUserFunction.Phone = [phone]
            
            Return ContractHandler.SendRequestAsync(Of AddUserFunction)(addUserFunction)
        
        End Function

        
        Public Function AddUserRequestAndWaitForReceiptAsync(ByVal [name] As String, ByVal [location] As String, ByVal [email] As String, ByVal [phone] As String, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Dim addUserFunction = New AddUserFunction()
                addUserFunction.Name = [name]
                addUserFunction.Location = [location]
                addUserFunction.Email = [email]
                addUserFunction.Phone = [phone]
            
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of AddUserFunction)(addUserFunction, cancellationToken)
        
        End Function
        Public Function GetAllServiceProvidersQueryAsync(ByVal getAllServiceProvidersFunction As GetAllServiceProvidersFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of List(Of String))
        
            Return ContractHandler.QueryAsync(Of GetAllServiceProvidersFunction, List(Of String))(getAllServiceProvidersFunction, blockParameter)
        
        End Function

        
        Public Function GetAllServiceProvidersQueryAsync(ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of List(Of String))
        
            return ContractHandler.QueryAsync(Of GetAllServiceProvidersFunction, List(Of String))(Nothing, blockParameter)
        
        End Function



        Public Function GetAllUsersQueryAsync(ByVal getAllUsersFunction As GetAllUsersFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of List(Of String))
        
            Return ContractHandler.QueryAsync(Of GetAllUsersFunction, List(Of String))(getAllUsersFunction, blockParameter)
        
        End Function

        
        Public Function GetAllUsersQueryAsync(ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of List(Of String))
        
            return ContractHandler.QueryAsync(Of GetAllUsersFunction, List(Of String))(Nothing, blockParameter)
        
        End Function



        Public Function Service_providersQueryAsync(ByVal service_providersFunction As Service_providersFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of String)
        
            Return ContractHandler.QueryAsync(Of Service_providersFunction, String)(service_providersFunction, blockParameter)
        
        End Function

        
        Public Function Service_providersQueryAsync(ByVal [returnValue1] As BigInteger, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of String)
        
            Dim service_providersFunction = New Service_providersFunction()
                service_providersFunction.ReturnValue1 = [returnValue1]
            
            Return ContractHandler.QueryAsync(Of Service_providersFunction, String)(service_providersFunction, blockParameter)
        
        End Function


        Public Function Sp_AddressesQueryAsync(ByVal sp_AddressesFunction As Sp_AddressesFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of String)
        
            Return ContractHandler.QueryAsync(Of Sp_AddressesFunction, String)(sp_AddressesFunction, blockParameter)
        
        End Function

        
        Public Function Sp_AddressesQueryAsync(ByVal [returnValue1] As BigInteger, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of String)
        
            Dim sp_AddressesFunction = New Sp_AddressesFunction()
                sp_AddressesFunction.ReturnValue1 = [returnValue1]
            
            Return ContractHandler.QueryAsync(Of Sp_AddressesFunction, String)(sp_AddressesFunction, blockParameter)
        
        End Function


        Public Function UserExistQueryAsync(ByVal userExistFunction As UserExistFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of Boolean)
        
            Return ContractHandler.QueryAsync(Of UserExistFunction, Boolean)(userExistFunction, blockParameter)
        
        End Function

        
        Public Function UserExistQueryAsync(ByVal [address] As String, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of Boolean)
        
            Dim userExistFunction = New UserExistFunction()
                userExistFunction.Address = [address]
            
            Return ContractHandler.QueryAsync(Of UserExistFunction, Boolean)(userExistFunction, blockParameter)
        
        End Function


        Public Function User_AddressesQueryAsync(ByVal user_AddressesFunction As User_AddressesFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of String)
        
            Return ContractHandler.QueryAsync(Of User_AddressesFunction, String)(user_AddressesFunction, blockParameter)
        
        End Function

        
        Public Function User_AddressesQueryAsync(ByVal [returnValue1] As BigInteger, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of String)
        
            Dim user_AddressesFunction = New User_AddressesFunction()
                user_AddressesFunction.ReturnValue1 = [returnValue1]
            
            Return ContractHandler.QueryAsync(Of User_AddressesFunction, String)(user_AddressesFunction, blockParameter)
        
        End Function


    
    End Class

End Namespace
