import React from 'react'
import abc from './images/abc.png';
class  Payement extends React.Component{

    constructor(props){
        super(props);
        this.state ={account:this.props.account, contract : this.props.contract};
    }
    
    onClick = async (e) => {
        e.preventDefault();
       await this.state.contract.methods.servicecompleted().send({from:this.state.account}); 
       alert('paid');
       
    
      }
      render(){

    return (
        <div>
           <button onClick={this.onClick} height= "100%"> click on this to pay to the service provider </button>
      <div>
            <img src={abc}  width= "100%" height="60%"/>
       </div>
        </div>
    )}
}

export default Payement;
