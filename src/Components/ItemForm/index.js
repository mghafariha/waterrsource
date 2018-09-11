import React from 'react';
import {connect} from 'react-redux';
import moment from 'moment-jalaali';
import VisitForm from '../VisitForm';
import InfractionForm from '../InfractionForm';
import {addItem, setFieldValue,setItem} from '../../store/action';

import {saveItem,getItem,updateItem} from '../../api';
import {getUrlVars} from '../../Constants/functions'
import Modal from 'react-modal';


class ItemForm extends React.Component{
        constructor(props){
            super(props);
           
        }    
        componentDidMount=(e)=>{
           // let itmId=getUrlVars()['ID'];
            //console.log('itmid',itmId);
        
            
        }

    render(){
    
        return(
        //     <Modal
        //     isOpen={this.state.open}
        //     onAfterOpen={this.afterOpenModal}
        //     onRequestClose={this.closeModal}
        //     style={customStyles}
        //     contentLabel="Example Modal"
        //   >
            <div>
                <VisitForm {...this.props}/>
                {this.props.formName=='Display'? <InfractionForm visitedID={this.props.item['ID']} {...this.props} />:null}
               
                </div>
        )
    }
}
const mapStateToProps=state=>({
    item:state.item
})
export default connect(mapStateToProps)(ItemForm)