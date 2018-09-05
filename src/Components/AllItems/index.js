import React from 'react';
import {connect} from 'react-redux';
import {moment} from 'moment-jalaali';
import ItemRow from '../ItemRow';
import ItemForm from '../ItemForm';
import {getAllItems} from '../../api';
import {setAllItems,deleteItem} from '../../store/action'
import 'react-table/react-table.css';
import Modal from 'react-modal';

// import '../../../node_modules/bootstrap/dist/css/bootstrap.min.css'; 
// import BootstrapTable from 'react-bootstrap-table-next';
// import filterFactory, { textFilter } from 'react-bootstrap-table2-filter';
import ReactTable from "react-table";
import { ReactTableDefaults } from "react-table";


Modal.setAppElement('#root');
const customStyles = {
  content : {
  top                   : '50%',
  left                  : '50%',
  right                 : 'auto',
  bottom                : 'auto',
  marginRight           : '-50%',
  transform             : 'translate(-50%, -50%)'
  }
  };
class AllItems extends React.Component{

    constructor(props){
        super(props);
        this.state={datatsource:[],column:[], 
          showModal: false,
          selectedItem:{},formName:''
        }
    }

    handleClick(event) {  // switch the value of the showModal state
      this.setState({
        showModal: !this.state.showModal
      });
    }
    handleOpenModal =(e)=> {
      this.setState({ showModal: true });
    }
    
    handleCloseModal =(e)=> {
      this.setState({ showModal: false });
    }
   handleChange=(e)=>{
   
     this.props.dispatch(deleteItem(e));
     this.setState({datasource:this.props.items.map((itm,index)=>({...itm,key:index}))})
   }
  componentDidMount=(e)=>{

    getAllItems().then((response)=>{
        
        this.props.dispatch(setAllItems((response.data)));
       
       this.setState({datasource:this.props.items.map((itm,index)=>({...itm,key:index}))})   

    })
  }
    render(){
        Object.assign(ReactTableDefaults, {
            defaultPageSize: 5,
            minRows: 3
            // etc...
          });
        const columns = [{
            Header: 'ID',
            accessor: 'ID' // String-based value accessors!
          }, {
            Header: 'طول جغرافیایی',
            accessor: 'LongitudeWell',
           
          },{
            Header: 'عرض جغرافیایی',
            accessor: 'LatitudeWell',
           
          },{
            Header: 'DateCensus',
            id: 'DateCensus',
           // accessor:  props => <div> {moment(props.value).format('YY/MM/DD')} </div>
           accessor:'DateCensus'
          },{
            Header: 'عملیات',
            id: 'action',
           // accessor:  props => <div> {moment(props.value).format('YY/MM/DD')} </div>
           accessor:'Action',
           Cell: row => (
             <span>
           <button onClick={ ()=> {this.setState({ showModal: true,selectedItem:row.original,formName:'Display' });}}>نمایش</button>
            <button onClick={ ()=> {this.setState({ showModal: true,selectedItem:row.original,formName:'Edit' });}}>ویرایش</button>
           <button onClick={()=> {this.props.dispatch(deleteItem(row.original));
                            this.setState({datasource:this.props.items.map((itm,index)=>({...itm,key:index}))})}} >حذف</button>
           
           <div>
                <Modal 
                   isOpen={this.state.showModal}
                   contentLabel="onRequestClose Example"
                   onRequestClose={this.handleCloseModal}
                >
                  <ItemForm formName={this.state.formName} selectedItem={this.state.selectedItem}/>
                  <button onClick={this.handleCloseModal}>Close Modal</button>
                </Modal>
              </div>
          
          </span>
          ) 
          
          }
        ]




        console.log('items', this.props.items);
        return(
           
            <ReactTable
                    data={this.state.datasource}
                    noDataText="اطلاعاتی وجود ندارد"
                    filterable
                    defaultFilterMethod={(filter, row) =>
                      String(row[filter.id]) === filter.value}
                    columns={columns}
                    className="-striped -highlight"
                />
            //  <BootstrapTable   
            
            //     pagination={true}
            //     search={true}
            //     selectRow={this.state.selectRowProp} data={ this.state.datasource } columns={this.state.columns }  filter={ filterFactory() }
            //     keyField='ID' 
            //     /> 
             
        )
    }
}


const mapStateToProps=(state)=>({
    items:state.items
})
export default connect(mapStateToProps)(AllItems)


