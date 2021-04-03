import 'react-bootstrap'
import React,{useEffect, useState} from 'react';
import './App.css';
import Web3 from 'web3'
import ModelABI from './contracts/Model.json';
import RegisterScreen from "./components/RegisterScreen";

function App() {
  let currentAccount = 0;
  const [contract, setContract] = useState();
  let existingUser = true;

  useEffect(()=> {
    loadWeb3();
    connectBlockChainData();
  },[]);

  const addUser = async (name, location, email, phone) => {
    await contract
        .methods
        .addUser(name, location, email, phone)
        .send({from : currentAccount});

  };

  const loadWeb3 = async () => {
    if (window.ethereum) {
      window.web3 = new Web3(window.ethereum)
      await window.ethereum.enable()
      console.log("successfully into first case");
    }
    else if (window.web3) {
      window.web3 = new Web3(window.web3.currentProvider)
      console.log("successfully into second case")
    }
    else {
      window.alert('Non-Ethereum browser detected. You should consider trying MetaMask!')
    }
  }

  const connectBlockChainData = async() =>{
    const web3 = await new Web3(Web3.givenProvider || "http://localhost:8545")
    const accounts = await web3.eth.getAccounts()
    currentAccount = accounts[0];
    console.log(accounts[0]);
    console.log(currentAccount);
    const networkId = await web3.eth.net.getId();
    const networkData = ModelABI.networks[networkId];
    if(networkData){
      const Model = new web3.eth.Contract(ModelABI.abi,networkData.address);
      setContract(Model);
      existingUser =await Model.methods.userExist(currentAccount).call();
      console.log(existingUser);
    }
    else{
      window.alert("Please switch to Rinkeby Network!!")
    }
  }

  const renderAuthButton = () => {
    if(existingUser == false)
      return <RegisterScreen Account ={currentAccount} />
    else
      return <h1>hello</h1>
  }
  return (

        <div className="App">
          {

            renderAuthButton()
          }
        </div>);



}

export default App;
