import React from 'react';
import {connect} from 'react-redux';
import moment from 'moment-jalaali';
import VisitForm from '../VisitForm';
import InfractionForm from '../InfractionForm';
import {addItem, setFieldValue,setItem,changeItem,setColumns} from '../../store/action';
import Field from '../Field';
import {saveItem,getItem,updateItem} from '../../api';
import {getUrlVars} from '../../Constants/functions'
import Modal from 'react-modal';
import '../../styles/style.css';
import Loader from '../Loader';
import Profile from '../../Forms/Well/Visit'


class ItemForm extends React.Component{
        constructor(props){
            super(props);
           this.state={ columns: {},loading:true}
           
        }    
        hasError=(fields)=>{
            let requiredFiels = Object.values(fields).filter((item) => (item.errorMessge))
            return requiredFiels.length != 0
        }
        checkRequired = () =>{
            let requiredFields = this.props.fields.
            filter((itm)=>
             itm.required && !this.props.item[itm.accessor]).
             map((item)=>
              ({...item, errorMessge: 'این فیلد الزامی است'}))
             
            let newFields = this.props.fields.map(col=>requiredFields.find(itm=>itm.accessor==col.accessor)?requiredFields.find(itm=>itm.accessor==col.accessor):{...col,errorMessge:''}) ;
            this.props.dispatch(setColumns(this.props.storeIndex,newFields))
            return newFields
        }
        componentDidMount=(e)=>{
           // let itmId=getUrlVars()['ID'];
            this.props.dispatch(setItem(this.props.selectedItem,this.props.storeIndex));
            this.setState({loading:false});
            console.log('fields', this.props.fields);
        }

        handleSubmit=(e)=>{
          
            this.setState({loading:true})
            e.preventDefault();
            let fields = this.checkRequired()
           
            if (this.hasError(fields)) {
            alert('در  اطلاعات وارد شده خطا وجود دارد.')

            } else {
                let lookupFields= fields.filter(field=>field.type=='Lookup');
                let saveItm=Object.keys(this.props.item).reduce((result,key)=>{if(typeof(this.props.item[key])!='object') result[key]=this.props.item[key] ;return result;},{});
            if(!this.props.item['ID'])
            {
                console.log('fields', this.props.fields)
                
            //    let saveItm=Object.keys(this.props.item).reduce((result,key)=>{result[key]=(lookupFields.find(itm=>itm.accessor==key)?{ID:this.props.item[key].option[value]}:this.props.item[key]); return result;},{})
         
               //console.log('saveItem',saveItm);
          
           console.log('item',this.props.item)

          
              saveItem(saveItm,this.props.storeIndex).then((response)=>{
                alert('آیتم جدید با موفقیت ذخیره شد');
                this.props.dispatch(addItem({...this.props.item,'ID':response.data.ID},this.props.storeIndex));
               this.props.dispatch(setItem({},this.props.storeIndex));
               if (!!this.props.closeAfterSave) {
                this.props.closeAfterSave();
              }
              }).catch((error)=>console.log(error));
            }
        else{
         //   let saveItm=Object.keys(this.props.item).reduce((result,key)=>{if(typeof(this.props.item[key])!='object') result[key]=this.props.item[key] ;return result;},{});
            updateItem(saveItm,this.props.storeIndex).then((response)=>{
                alert('آیتم با موفقیت بروزرسانی شد');
        
                this.props.dispatch(changeItem(this.props.item,this.props.storeIndex));
                //this.getTitle.value='';
              //  this.getDescription.value='';
               this.props.dispatch(setItem({},this.props.storeIndex));
               if (!!this.props.closeAfterSave) {
                this.props.closeAfterSave();
              }
            }).catch((error)=>console.log(error));
        }
        
        }
        
    }

    render(){
    
        return ( 
            <form onSubmit={this.handleSubmit}>
                <h1></h1>
                <div className='form-contents'  >
               { this.props.fields.map((field,index)=>field.accessor!='ID'? <Field 
                        key={field.accessor}
                        internalName={field.accessor}
                        storeIndex={this.props.storeIndex}
                        formName={this.props.formName}
                      
                    />:null)}
                      </div>
                    {this.props.formName!='Display'?  <button  type="submit">ذخیره</button>:null}
            </form>

        )
    }
}
const mapStateToProps=(state,props)=>({
    fields:state.columns[props.storeIndex],
    item:state.item[props.storeIndex],
    items:state.items[props.storeIndex],
    modal:true
})
//export default withRouter(connect(mapStateToProps)(ItemForm))
export default connect(mapStateToProps)(ItemForm)