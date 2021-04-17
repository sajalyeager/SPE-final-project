
 import abd from './images/abd.jpg';
 import {withRouter} from "react-router";
 import React, {Component, useState} from "react";
 
class Status extends Component{ 
    constructor(props){
        super(props);
        this.state ={account:this.props.account, contract : this.props.contract};
    }
    shoot=async(e)=> {
        e.preventDefault();
       await this.state.contract.methods.service_off().send({from:this.state.account}); 
       alert('submittted');
       
    
      } 
      render(){
    return (
        <div>
       <button onClick={this.shoot} height= "100%"> click on this to change the status </button>
      <div>
       <img src={abd}  width= "100%" height="60%"/>
       </div>

        </div>
    )}
}

export default withRouter(Status);
