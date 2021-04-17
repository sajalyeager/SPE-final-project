import React from 'react'

class Providerchoices extends React.Component {
  
constructor(props){
  super(props);
  this.state={ contract :this.props.contract,
               account : this.props.account

  };

}
componentWillMount(){
   this.loc();
}
loc= async()=>{
      let v=null;
     await this.state.contract.methods.ServiceProviders(this.state.account).call()
     .then(function (result){
      v = result[4];
      console.log(v);
  });
   let i=0;
   let x=null;
   let z=[0];
   for(;i<v.length;i++){
    await this.state.contract.methods.Users(v[i]).call()
    .then(function (result){
     x = result;
     z.push(x);
 });

   }
}



  render(){
    return (
        <div>
           <h>sajal</h> 
        </div>
    )
}
}

export default Providerchoices
