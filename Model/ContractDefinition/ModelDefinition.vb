Imports System
Imports System.Threading.Tasks
Imports System.Collections.Generic
Imports System.Numerics
Imports Nethereum.Hex.HexTypes
Imports Nethereum.ABI.FunctionEncoding.Attributes
Imports Nethereum.Web3
Imports Nethereum.RPC.Eth.DTOs
Imports Nethereum.Contracts.CQS
Imports Nethereum.Contracts
Imports System.Threading
Namespace SPEFinalProject.Contracts.Model.ContractDefinition

    
    
    Public Partial Class ModelDeployment
     Inherits ModelDeploymentBase
    
        Public Sub New()
            MyBase.New(DEFAULT_BYTECODE)
        End Sub
        
        Public Sub New(ByVal byteCode As String)
            MyBase.New(byteCode)
        End Sub
    
    End Class

    Public Class ModelDeploymentBase 
            Inherits ContractDeploymentMessage
        
        Public Shared DEFAULT_BYTECODE As String = "608060405260006003556000600455600060055560006006556000600755600060085560006009556000600a5534801561003857600080fd5b50611116806100486000396000f3fe6080604052600436106100915760003560e01c806399b956a01161005957806399b956a014610162578063a7912cde14610194578063ab7e7cf6146101a7578063e2842d79146101d7578063f234687d146101ec57610091565b806301cda3ac1461009657806304a15d74146100ab57806372eb7b60146100d65780637bc9883c1461010a5780639741edef14610142575b600080fd5b6100a96100a4366004610d17565b61020c565b005b3480156100b757600080fd5b506100c061034e565b6040516100cd9190610f01565b60405180910390f35b3480156100e257600080fd5b506100f66100f1366004610cf4565b6103b0565b6040516100cd989796959493929190610fbf565b34801561011657600080fd5b5061012a610125366004610dbf565b6106a3565b6040516001600160a01b0390911681526020016100cd565b34801561014e57600080fd5b5061012a61015d366004610dbf565b6106cd565b34801561016e57600080fd5b5061018261017d366004610cf4565b6106dd565b6040516100cd96959493929190610f4e565b6100a96101a2366004610dd7565b61093c565b3480156101b357600080fd5b506101c76101c2366004610cf4565b610b35565b60405190151581526020016100cd565b3480156101e357600080fd5b506100c0610b64565b3480156101f857600080fd5b5061012a610207366004610dbf565b610bc4565b6005805490600061021c8361108b565b9091555050600380549060006102318361108b565b90915550506001805480820182557fb10e2d527612073b26eecdfd717e6a320cf44b4afac2b0732d9fcbe2b7fa0cf6018054336001600160a01b031991821681179092556040805160c081018252600354815260208082018581528284018b8152606084018b9052608084018a905260a084018990526000878152600b84529490942083518155905196810180549095166001600160a01b0390971696909617909355905180519394919391926102f092600285019290910190610bd4565b506060820151805161030c916003840191602090910190610bd4565b5060808201518051610328916004840191602090910190610bd4565b5060a08201518051610344916005840191602090910190610bd4565b5050505050505050565b606060028054806020026020016040519081016040528092919081815260200182805480156103a657602002820191906000526020600020905b81546001600160a01b03168152600190910190602001808311610388575b5050505050905090565b600c6020526000908152604090208054600182015460028301805492936001600160a01b03909216926103e290611050565b80601f016020809104026020016040519081016040528092919081815260200182805461040e90611050565b801561045b5780601f106104305761010080835404028352916020019161045b565b820191906000526020600020905b81548152906001019060200180831161043e57829003601f168201915b50505050509080600301805461047090611050565b80601f016020809104026020016040519081016040528092919081815260200182805461049c90611050565b80156104e95780601f106104be576101008083540402835291602001916104e9565b820191906000526020600020905b8154815290600101906020018083116104cc57829003601f168201915b5050505050908060040180546104fe90611050565b80601f016020809104026020016040519081016040528092919081815260200182805461052a90611050565b80156105775780601f1061054c57610100808354040283529160200191610577565b820191906000526020600020905b81548152906001019060200180831161055a57829003601f168201915b50505050509080600501805461058c90611050565b80601f01602080910402602001604051908101604052809291908181526020018280546105b890611050565b80156106055780601f106105da57610100808354040283529160200191610605565b820191906000526020600020905b8154815290600101906020018083116105e857829003601f168201915b50505050509080600601805461061a90611050565b80601f016020809104026020016040519081016040528092919081815260200182805461064690611050565b80156106935780601f1061066857610100808354040283529160200191610693565b820191906000526020600020905b81548152906001019060200180831161067657829003601f168201915b5050505050908060070154905088565b600281815481106106b357600080fd5b6000918252602090912001546001600160a01b0316905081565b600081815481106106b357600080fd5b600b6020526000908152604090208054600182015460028301805492936001600160a01b039092169261070f90611050565b80601f016020809104026020016040519081016040528092919081815260200182805461073b90611050565b80156107885780601f1061075d57610100808354040283529160200191610788565b820191906000526020600020905b81548152906001019060200180831161076b57829003601f168201915b50505050509080600301805461079d90611050565b80601f01602080910402602001604051908101604052809291908181526020018280546107c990611050565b80156108165780601f106107eb57610100808354040283529160200191610816565b820191906000526020600020905b8154815290600101906020018083116107f957829003601f168201915b50505050509080600401805461082b90611050565b80601f016020809104026020016040519081016040528092919081815260200182805461085790611050565b80156108a45780601f10610879576101008083540402835291602001916108a4565b820191906000526020600020905b81548152906001019060200180831161088757829003601f168201915b5050505050908060050180546108b990611050565b80601f01602080910402602001604051908101604052809291908181526020018280546108e590611050565b80156109325780601f1061090757610100808354040283529160200191610932565b820191906000526020600020905b81548152906001019060200180831161091557829003601f168201915b5050505050905086565b6006805490600061094c8361108b565b9091555050600480549060006109618361108b565b909155505060028054600180820183557f405787fa12a823e0f2b7631cc41b3ba8828b3321ca811111fa75cd3aa3bb5ace9091018054336001600160a01b031991821681179092556040805161010081018252600454815260208082018581528284018e8152606084018e9052608084018d905260a084018c905260c084018b905260e084018a90526000878152600c84529490942083518155905196810180549095166001600160a01b0390971696909617909355905180519395919493610a3293928501929190910190610bd4565b5060608201518051610a4e916003840191602090910190610bd4565b5060808201518051610a6a916004840191602090910190610bd4565b5060a08201518051610a86916005840191602090910190610bd4565b5060c08201518051610aa2916006840191602090910190610bd4565b5060e082015181600701559050508760011415610acf5760078054906000610ac98361108b565b91905055505b8760021415610aee5760088054906000610ae88361108b565b91905055505b8760031415610b0d5760098054906000610b078361108b565b91905055505b876004141561034457600a8054906000610b268361108b565b91905055505050505050505050565b6001600160a01b0381166000908152600b602052604081205415610b5b57506001610b5f565b5060005b919050565b606060018054806020026020016040519081016040528092919081815260200182805480156103a6576020028201919060005260206000209081546001600160a01b03168152600190910190602001808311610388575050505050905090565b600181815481106106b357600080fd5b828054610be090611050565b90600052602060002090601f016020900481019282610c025760008555610c48565b82601f10610c1b57805160ff1916838001178555610c48565b82800160010185558215610c48579182015b82811115610c48578251825591602001919060010190610c2d565b50610c54929150610c58565b5090565b5b80821115610c545760008155600101610c59565b600082601f830112610c7d578081fd5b813567ffffffffffffffff80821115610c9857610c986110b2565b604051601f8301601f19908116603f01168101908282118183101715610cc057610cc06110b2565b81604052838152866020858801011115610cd8578485fd5b8360208701602083013792830160200193909352509392505050565b600060208284031215610d05578081fd5b8135610d10816110c8565b9392505050565b60008060008060808587031215610d2c578283fd5b843567ffffffffffffffff80821115610d43578485fd5b610d4f88838901610c6d565b95506020870135915080821115610d64578485fd5b610d7088838901610c6d565b94506040870135915080821115610d85578384fd5b610d9188838901610c6d565b93506060870135915080821115610da6578283fd5b50610db387828801610c6d565b91505092959194509250565b600060208284031215610dd0578081fd5b5035919050565b600080600080600080600060e0888a031215610df1578283fd5b87359650602088013567ffffffffffffffff80821115610e0f578485fd5b610e1b8b838c01610c6d565b975060408a0135915080821115610e30578485fd5b610e3c8b838c01610c6d565b965060608a0135915080821115610e51578485fd5b610e5d8b838c01610c6d565b955060808a0135915080821115610e72578485fd5b610e7e8b838c01610c6d565b945060a08a0135915080821115610e93578384fd5b50610ea08a828b01610c6d565b92505060c0880135905092959891949750929550565b60008151808452815b81811015610edb57602081850181015186830182015201610ebf565b81811115610eec5782602083870101525b50601f01601f19169290920160200192915050565b6020808252825182820181905260009190848201906040850190845b81811015610f425783516001600160a01b031683529284019291840191600101610f1d565b50909695505050505050565b8681526001600160a01b038616602082015260c060408201819052600090610f7890830187610eb6565b8281036060840152610f8a8187610eb6565b90508281036080840152610f9e8186610eb6565b905082810360a0840152610fb28185610eb6565b9998505050505050505050565b8881526001600160a01b038816602082015261010060408201819052600090610fea8382018a610eb6565b90508281036060840152610ffe8189610eb6565b905082810360808401526110128188610eb6565b905082810360a08401526110268187610eb6565b905082810360c084015261103a8186610eb6565b9150508260e08301529998505050505050505050565b600181811c9082168061106457607f821691505b6020821081141561108557634e487b7160e01b600052602260045260246000fd5b50919050565b60006000198214156110ab57634e487b7160e01b81526011600452602481fd5b5060010190565b634e487b7160e01b600052604160045260246000fd5b6001600160a01b03811681146110dd57600080fd5b5056fea26469706673582212205d4b5c6f88757dcbed3b867093a3ada3e13ee20be93030047f4f7b5df8f5c4df64736f6c63430008030033"
        
        Public Sub New()
            MyBase.New(DEFAULT_BYTECODE)
        End Sub
        
        Public Sub New(ByVal byteCode As String)
            MyBase.New(byteCode)
        End Sub
        

    
    End Class    
    
    Public Partial Class ServiceProvidersFunction
        Inherits ServiceProvidersFunctionBase
    End Class

        <[Function]("ServiceProviders", GetType(ServiceProvidersOutputDTO))>
    Public Class ServiceProvidersFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("address", "", 1)>
        Public Overridable Property [ReturnValue1] As String
    
    End Class
    
    
    Public Partial Class UsersFunction
        Inherits UsersFunctionBase
    End Class

        <[Function]("Users", GetType(UsersOutputDTO))>
    Public Class UsersFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("address", "", 1)>
        Public Overridable Property [ReturnValue1] As String
    
    End Class
    
    
    Public Partial Class AddServiceProviderFunction
        Inherits AddServiceProviderFunctionBase
    End Class

        <[Function]("addServiceProvider")>
    Public Class AddServiceProviderFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("uint256", "service_type", 1)>
        Public Overridable Property [Service_type] As BigInteger
        <[Parameter]("string", "name", 2)>
        Public Overridable Property [Name] As String
        <[Parameter]("string", "location", 3)>
        Public Overridable Property [Location] As String
        <[Parameter]("string", "service", 4)>
        Public Overridable Property [Service] As String
        <[Parameter]("string", "email", 5)>
        Public Overridable Property [Email] As String
        <[Parameter]("string", "phone", 6)>
        Public Overridable Property [Phone] As String
        <[Parameter]("uint256", "charges", 7)>
        Public Overridable Property [Charges] As BigInteger
    
    End Class
    
    
    Public Partial Class AddUserFunction
        Inherits AddUserFunctionBase
    End Class

        <[Function]("addUser")>
    Public Class AddUserFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("string", "name", 1)>
        Public Overridable Property [Name] As String
        <[Parameter]("string", "location", 2)>
        Public Overridable Property [Location] As String
        <[Parameter]("string", "email", 3)>
        Public Overridable Property [Email] As String
        <[Parameter]("string", "phone", 4)>
        Public Overridable Property [Phone] As String
    
    End Class
    
    
    Public Partial Class GetAllServiceProvidersFunction
        Inherits GetAllServiceProvidersFunctionBase
    End Class

        <[Function]("getAllServiceProviders", "address[]")>
    Public Class GetAllServiceProvidersFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class GetAllUsersFunction
        Inherits GetAllUsersFunctionBase
    End Class

        <[Function]("getAllUsers", "address[]")>
    Public Class GetAllUsersFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class Service_providersFunction
        Inherits Service_providersFunctionBase
    End Class

        <[Function]("service_providers", "address")>
    Public Class Service_providersFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("uint256", "", 1)>
        Public Overridable Property [ReturnValue1] As BigInteger
    
    End Class
    
    
    Public Partial Class Sp_AddressesFunction
        Inherits Sp_AddressesFunctionBase
    End Class

        <[Function]("sp_Addresses", "address")>
    Public Class Sp_AddressesFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("uint256", "", 1)>
        Public Overridable Property [ReturnValue1] As BigInteger
    
    End Class
    
    
    Public Partial Class UserExistFunction
        Inherits UserExistFunctionBase
    End Class

        <[Function]("userExist", "bool")>
    Public Class UserExistFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("address", "Address", 1)>
        Public Overridable Property [Address] As String
    
    End Class
    
    
    Public Partial Class User_AddressesFunction
        Inherits User_AddressesFunctionBase
    End Class

        <[Function]("user_Addresses", "address")>
    Public Class User_AddressesFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("uint256", "", 1)>
        Public Overridable Property [ReturnValue1] As BigInteger
    
    End Class
    
    
    Public Partial Class ServiceProvidersOutputDTO
        Inherits ServiceProvidersOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class ServiceProvidersOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("uint256", "id", 1)>
        Public Overridable Property [Id] As BigInteger
        <[Parameter]("address", "Address", 2)>
        Public Overridable Property [Address] As String
        <[Parameter]("string", "name", 3)>
        Public Overridable Property [Name] As String
        <[Parameter]("string", "location", 4)>
        Public Overridable Property [Location] As String
        <[Parameter]("string", "service", 5)>
        Public Overridable Property [Service] As String
        <[Parameter]("string", "phone", 6)>
        Public Overridable Property [Phone] As String
        <[Parameter]("string", "email", 7)>
        Public Overridable Property [Email] As String
        <[Parameter]("uint256", "charges", 8)>
        Public Overridable Property [Charges] As BigInteger
    
    End Class    
    
    Public Partial Class UsersOutputDTO
        Inherits UsersOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class UsersOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("uint256", "id", 1)>
        Public Overridable Property [Id] As BigInteger
        <[Parameter]("address", "AddresLoopss", 2)>
        Public Overridable Property [AddresLoopss] As String
        <[Parameter]("string", "name", 3)>
        Public Overridable Property [Name] As String
        <[Parameter]("string", "location", 4)>
        Public Overridable Property [Location] As String
        <[Parameter]("string", "email", 5)>
        Public Overridable Property [Email] As String
        <[Parameter]("string", "phone", 6)>
        Public Overridable Property [Phone] As String
    
    End Class    
    
    
    
    
    
    Public Partial Class GetAllServiceProvidersOutputDTO
        Inherits GetAllServiceProvidersOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class GetAllServiceProvidersOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("address[]", "", 1)>
        Public Overridable Property [ReturnValue1] As List(Of String)
    
    End Class    
    
    Public Partial Class GetAllUsersOutputDTO
        Inherits GetAllUsersOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class GetAllUsersOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("address[]", "", 1)>
        Public Overridable Property [ReturnValue1] As List(Of String)
    
    End Class    
    
    Public Partial Class Service_providersOutputDTO
        Inherits Service_providersOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class Service_providersOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("address", "", 1)>
        Public Overridable Property [ReturnValue1] As String
    
    End Class    
    
    Public Partial Class Sp_AddressesOutputDTO
        Inherits Sp_AddressesOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class Sp_AddressesOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("address", "", 1)>
        Public Overridable Property [ReturnValue1] As String
    
    End Class    
    
    Public Partial Class UserExistOutputDTO
        Inherits UserExistOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class UserExistOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("bool", "", 1)>
        Public Overridable Property [ReturnValue1] As Boolean
    
    End Class    
    
    Public Partial Class User_AddressesOutputDTO
        Inherits User_AddressesOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class User_AddressesOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("address", "", 1)>
        Public Overridable Property [ReturnValue1] As String
    
    End Class
End Namespace
