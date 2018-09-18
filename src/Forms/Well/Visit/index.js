import React from 'react';
import {connect} from 'react-redux'
import {setAllItems,setColumns} from '../../../store/action';
import {getAllVisitItem} from '../../../api';
import ColumnSelect from '../../../Components/DataGrid/ColumnSelect'
import Table from '../../../Components/DataGrid/Table';
import WellVisitItem from './item';
import {fields} from './fields';



class WellVisit extends React.Component{
    constructor(props){
        super(props);

    }
    handleClick=()=>{

    }
   
    componentDidMount(){  
        console.log('fieldssss',fields);
        getAllVisitItem().then((response)=>{
                this.props.dispatch(setAllItems('WellVisiteds',response.data));
                this.props.dispatch(setColumns('WellVisiteds',fields));
                // this.props.dispatch(setColumns('WellVisiteds'),fields)

                 console.log('visite columns',this.props.columns);
                
        })
    }
    render(){

        return(<div>
            <ColumnSelect  storeIndex='WellVisiteds' {...this.props} />
            <Table   itemIndex={WellVisitItem} storeIndex='WellVisiteds' {...this.props}  /> 

           
            </div>)
    }
}
const mapStateToProps=(state)=>({columns:state.columns['WellVisiteds'],items:state.items['WellVisiteds']})
export default  connect(mapStateToProps)(WellVisit)
