import React from 'react';
import {connect} from 'react-redux'
import {setAllItems,setColumns} from '../../../store/action';
import {getAllItem,getMetaData} from '../../../api';
import ColumnSelect from '../../../Components/DataGrid/ColumnSelect'
import Table from '../../../Components/DataGrid/Table';
import WellVisitItem from './item';
import {fields} from './fields';
import axios from 'axios';
import Loader from '../../../Components/Loader';


class WellVisit extends React.Component{
    constructor(props){
        super(props);
        this.state={loading:true,showColumnSelect:false}

    }
    loadColumns=(e)=>{
        var active = !this.state.showColumnSelect;
        this.setState({showColumnSelect:active})

    }
   
    componentDidMount(){  
        axios.all([getAllItem('WellVisiteds'),getMetaData(2)]).then(axios.spread((response,columns)=>{
        console.log('wellvisited',response.data)
            this.props.dispatch(setAllItems('WellVisiteds',response.data));
        //    const col=[... columns.data.map(itm=>Object.assign({},{Header:itm.DisplayName,accessor:itm.Name,type:itm.Type,required:itm.Required,IsMulti:itm.IsMulti,Options:itm.Options})),{Header:'فایل',accessor:'File1',type:'File',required:'false',IsMulti:false,Options:null}];
          
            this.props.dispatch(setColumns('WellVisiteds',columns.data.map((itm,index)=>Object.assign({},{Header:itm.DisplayName,accessor:itm.Name,type:itm.Type,required:itm.Required,IsMulti:itm.IsMulti,Options:itm.Options?itm.Options.split(';'):null,TitleField:itm.TitleField?itm.TitleField:null,isChecked:(index<5?true:false)}))));
            this.setState({loading:false});
           }));

    }
    render(){
       
       
        return(  <div>
             <div className='butt-input myrow ' > <input type='button' onClick={this.loadColumns} value='انتخاب ستون ها' /> </div>
             { this.state.showColumnSelect?  <ColumnSelect  storeIndex='WellVisiteds' {...this.props} />:null}
            
            <Table   itemIndex={WellVisitItem} storeIndex='WellVisiteds' {...this.props} showEdit={true} showRemove={true} showNew={true}  /> 

           
            </div>)
    }
}
const mapStateToProps=(state)=>({columns:state.columns['WellVisiteds'],items:state.items['WellVisiteds']})
export default  connect(mapStateToProps)(WellVisit)
