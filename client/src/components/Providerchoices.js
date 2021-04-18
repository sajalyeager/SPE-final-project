import React from 'react'
import 'react-bootstrap';
import "../css/table.css"
import '../css/RegisterScreen.css'
import User from "./userselection"
const green = '#FFd177';
const yellow = '#39D1B4';



class Providerchoices extends React.Component {

    constructor(props){
        super(props);
        this.state={ contract :this.props.contract,
            account : this.props.account,
            list:[]
        
            

        };
        

    }
    
    componentWillMount(){
        this.loc()
    
    }
    

    loc= async()=>{
        let v;
        v = await this.state.contract.methods.return_my_users(this.state.account).call();
        console.log(v);
        let i=0;
        let x=null;
        let z=[];
        for(;i<v.length;i++){
            await this.state.contract.methods.Users(v[i]).call()
                .then(function (result){
                    x = result;
                    z.push(x);
                });

        }
        this.setState({list:z});
        console.log(this.state.list);
        
    }

 


    render(){
        return (
            <div class> 
            
                
        
       { this.state.list.map((sp,index)=>(<div key={index}>
        <div className='users'>
                             <User sp ={sp} contract ={this.state.contract} account = {this.state.account}/>
                         </div>
                     </div>
                 ))}
        
       </ div>
        )}
       
    
    

} 
         


        
    



export default Providerchoices;