import React from 'react';
import {connect} from 'react-redux'
import {setAllItems,setColumns,checkedColumn} from '../../store/action';
import {getAllVisitItem} from '../../api';
import CheckBox from './CheckBox';





class ColumnSelect extends React.Component{
    constructor(props){
        super(props);

    }
   
    componentDidMount=()=>{  
        // getAllVisitItem().then((response)=>{
        //         this.props.dispatch(setAllItems('visitItems',response.data));

        //         this.props.dispatch(setColumns('visitItems',[{'Header':'شناسه','accessor':'ID'},{'Header':'طول جغرافیایی','accessor':'LongitudeWell'},{'Header':'عرض جغرافیایی','accessor':'LatitudeWell'},{'Header':'DateCensus','accessor':'DateCensus'},{'Header':'کد مالک','accessor':'OwnerCode'},{'Header':'موبایل مالک' ,'accessor':'OwnerMobile'},
        //         {'Header':'حجم مجاز برداشت(متر مکعب در سال)','accessor':'ApprovedVolume'},{'Header':'ساعت کارکرد سالانه' ,'accessor':'WorkHours'},{'Header':'میزان قدرت(برق)' ,'accessor':'PowerlevelElectricity'},{'Header':'میزان قدرت (دیزل)'  ,'accessor':'PowerlevelDiesel'},{'Header':'نوع مصرف آب بر اساس پرونده بهره برداری'  ,'accessor':'KindConsumptionWater'},{'Header':'لوله جدار' ,'accessor':'KindPipeline'}]));
        //         console.log('visite columns',this.props.columns);
                
        // })
    }

   
    render(){
    
      let storeIndex= this.props.storeIndex;
        return(<div>{
        this.props.columns.map(col => 
            <label key={col.accessor}>
              {col.Header}
              <CheckBox  internalName={col.accessor}  storeIndex={storeIndex} />
             </label> 
              
          )
         }
        
         </div>
        )
    }
}
const mapStateToProps=(state,props)=>({columns:state.columns[props.storeIndex],items:state.items[props.storeIndex]})
export default  connect(mapStateToProps)(ColumnSelect)
