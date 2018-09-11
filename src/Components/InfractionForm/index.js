import React from 'react';
import {connect} from 'react-redux';
import {getWellProfile} from '../../api';
import TextArea from './Components/TextArea';
import TextAreaWid from '../TextArea/widget';
import CheckBox from './Components/CheckBox';
import CheckBoxWid from '../CheckBox/widget';
import { setInfractionItem } from '../../store/action';


class InfractionForm extends React.Component{
constructor(props){
    super(props);
    this.state={profileItem:{}}

}
componentDidMount=(e)=>{
    getWellProfile(this.props.selectedItem['Profile']).then((result)=>{
        console.log('profileItem',result);
    this.setState({profileItem:result.data});

     }).catch((error)=>console.log(error));
}
handleSubmitInfraction=(e)=>{
    this.props.dispatch(setInfractionItem(this.props.infractionItem))
    console.log('infraction Item',this.props.infractionItem)
}
render(){
    return(<div>
       <div>
          <div>
                <span>عمق چاه</span>شناسنامه ای <span>{this.state.profileItem.WellDepth}</span>بازدید<span>{this.props.selectedItem.WellDepth}</span>اختلاف<span>{this.props.selectedItem.WellDepth}</span>
            </div>
            <div> <span> سطح آب</span>شناسنامه ای <span>{this.state.profileItem.WaterSurface}</span>بازدید<span>{this.props.selectedItem.WaterSurface}</span>اختلاف<span>{this.props.selectedItem.WaterSurface}</span>
            </div>
            <div>
            <span>DEBI</span>شناسنامه ای<span>{this.state.profileItem.DEBI}</span>بازدید<span>{this.props.selectedItem.DEBI}</span>اختلاف<span>{this.props.selectedItem.DEBI}</span>
            </div>
            <div><span>EC</span>شناسنامه ای<span>{this.state.profileItem.EC}</span>بازدید<span>{this.props.selectedItem.EC}</span>اختلاف<span>{this.props.selectedItem.EC}</span></div>
         </div>
            <br/>
        <div>
            <form onSubmit={this.handleSubmitInfraction}>
                ثبت تخلف
            <div><span>معیار 1</span>تخلف<CheckBox render={CheckBoxWid} internalName='measure1Check' /> توضیحات<TextArea render={TextAreaWid} internalName='measure1Description' /></div>
            <div><span>معیار 2</span>تخلف<CheckBox render={CheckBoxWid} internalName='measure2Check' /> توضیحات<TextArea render={TextAreaWid} internalName='measure2Description' /></div>
            <div><span>معیار 3</span>تخلف<CheckBox render={CheckBoxWid} internalName='measure3Check' /> توضیحات<TextArea render={TextAreaWid} internalName='measure3Description' /></div>
            <button>ثبت تخلف</button>
            </form>
        </div>
    </div>
    )
}

}
const mapStateToProps=(state)=>({infractionItem:state.infractionItem})
export default connect(mapStateToProps)(InfractionForm)