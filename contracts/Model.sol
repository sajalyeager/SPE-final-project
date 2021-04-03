// SPDX-License-Identifier: GPL-3.0
pragma solidity >=0.7.0 <0.9.0;

contract Model{
    // structure for Users
    struct User{
        uint id;
        address payable Address;
        string name;
        string location;
        string email;
        string phone;
    }


    // structure for Service Provider
    struct Service_Provider{
        uint id;
        address payable Address;
        string name;
        string location;
        string service;
        string phone;
        string email;
        uint charges;
    }


    address payable[] public  user_Addresses;
    address payable[] public sp_Addresses;
    uint usersId = 0;
    uint serviceProviderId = 0;
    uint usersCount = 0;
    uint serviceProviderCount = 0;

    mapping(address => User) public Users;
    mapping(address => Service_Provider) public ServiceProviders;

    // Function to add Users
    function addUser(string memory name, string memory location, string memory email, string memory phone) public payable{
        usersCount++;
        usersId++;
        address payable Address = payable(msg.sender);
        user_Addresses.push(Address);
        Users[Address] = User(usersId, Address, name, location,email,phone);
    }

    // Function to return the array of addresses of Users
    function getAllUsers() public view returns (address payable [] memory){
        return user_Addresses;
    }

    // to check if user exist already or not.
    function userExist(address payable Address) public view returns (bool){
        if (Users[Address].id>0){
            return true;
        }
        else
            return false;
    }

    // Function to add service providers
    function addServiceProvider(string memory name, string memory location, string memory service, string memory email, string memory phone, uint  charges ) public payable{
        serviceProviderCount++;
        serviceProviderId++;
        address payable Address = payable(msg.sender);
        sp_Addresses.push(Address);
        ServiceProviders[Address] = Service_Provider(serviceProviderId, Address, name, location,service, email,phone, charges);
    }

    //function to return the array of addresses of Service Providers
    function getAllServiceProviders() public view returns (address payable [] memory){
        return sp_Addresses;
    }
}