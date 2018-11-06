import React from 'react';
import {connect} from 'react-redux'
import {setAllItems,setColumns} from '../../../store/action';
import {getAllItem,getMetaData} from '../../../api';
import ColumnSelect from '../../../Components/DataGrid/ColumnSelect'
import Table from '../../../Components/DataGrid/Table';
import WellVisitItem from './item';
import {fields} from './fields';
import axios from 'axios';
import loader from '../../../Components/Loader';
import Loader from '../../../Components/Loader';


class WellProfile extends React.Component{
    constructor(props){
        super(props);
        this.state={showColumnSelect:false,loading:true}
    }
    loadColumns=(e)=>{
        var active = !this.state.showColumnSelect;
        this.setState({showColumnSelect:active})

    }
   
    componentDidMount(){  

        axios.all([getAllItem('WellProfiles'),getMetaData(1)]).then(axios.spread((response,columns)=>{
            this.props.dispatch(setColumns('WellProfiles',columns.data.map((itm,index)=>Object.assign({},{Header:itm.DisplayName,accessor:itm.Name,type:itm.Type,required:itm.Required,IsMulti:itm.IsMulti,Options:itm.Options?itm.Options.split(';'):null,TitleField:itm.TitleField?itm.TitleField:null,isChecked:(index<5?true:false)}))));
         
            this.props.dispatch(setAllItems('WellProfiles',response.data));
               this.setState({loading:false})    
                                  
          


            // response.data.map(item=>  Object.keys(item).reduce((result,key)=>{result[key]=(lookupFields.find(itm=>itm.accessor==key)?this.props.item[key.substring(0,key.length-2)]:this.props.item[key]); return result;},{}))
            
           }));

    }
    render(){

        return( <div>
          
           <div className='butt-input myrow ' > <input type='button' onClick={this.loadColumns} value='انتخاب ستون ها' /> </div>
            { this.state.showColumnSelect?  <ColumnSelect  storeIndex='WellProfiles' {...this.props} />:null}
            <Table   itemIndex={WellVisitItem} storeIndex='WellProfiles' {...this.props} showEdit={true} showRemove={true} showNew={true}  /> 

           
            </div>)
    }
}
const mapStateToProps=(state)=>({columns:state.columns['WellProfiles'],items:state.items['WellProfiles']})
export default  connect(mapStateToProps)(WellProfile)
