import React from 'react';
import {connect} from 'react-redux'
import {setAllItems,setColumns} from '../../../store/action';
import {getAllItem,getMetaData} from '../../../api';
import ColumnSelect from '../../../Components/DataGrid/ColumnSelect'
import Table from '../../../Components/DataGrid/Table';
import WellViolationItem from './item';
import {fields} from './fields';
import axios from 'axios';
import WellWorkFlow from '../Workflow';
import Loader from '../../../Components/Loader';

class WellViolation extends React.Component{

    constructor(props){
          super(props);
          this.state={loading:true,showColumnSelect:false}
    }
    loadColumns=(e)=>{
        var active = !this.state.showColumnSelect;
        this.setState({showColumnSelect:active})

    }
    componentDidMount(){
      
        axios.all([getAllItem('WellViolations'),getMetaData(3)]).then(axios.spread((response,columns)=>{
        
         this.props.dispatch(setAllItems('WellViolations',response.data));
         this.props.dispatch(setColumns('WellViolations',columns.data.map((itm,index)=>Object.assign({},{Header:itm.DisplayName,accessor:itm.Name,type:itm.Type,required:itm.Required,IsMulti:itm.IsMulti,Options:itm.Options?itm.Options.split(';'):null,TitleField:itm.TitleField?itm.TitleField:null,isChecked:(index<5?true:false)}))));
       
        this.setState({loading:false})
        }));
    }
    render(){
      return(   <div>
          <div className='butt-input myrow ' > <input type='button' onClick={this.loadColumns} value='انتخاب ستون ها' /> </div>
            { this.state.showColumnSelect? <ColumnSelect  storeIndex='WellViolations' {...this.props} />:null}
        

        <Table  itemIndex={WellViolationItem} storeIndex='WellViolations' {...this.props} showEdit={false} showRemove={false} showNew={true} workFlow={WellWorkFlow} /> 
        </div>)
    }
}
const mapStateToProps=(state,props)=>({

    columns:state.columns['WellViolations'],items:state.items['WellViolations']
})
export default connect(mapStateToProps)(WellViolation)