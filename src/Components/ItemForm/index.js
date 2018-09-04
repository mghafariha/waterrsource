import React from 'react';
import {connect} from 'react-redux';
import moment from 'moment-jalaali';
import {addItem, setFieldValue,setItem} from '../../store/action';
import Label from '../Label';
import TextWid from '../Text/widget';
import Text from '../Text';
import NumberWid from '../Number/widget';
import Number from '../Number';
import TextAreaWid from  '../TextArea/widget';
import TextArea from '../TextArea';
import DateWid from '../Date/widget';
import Date from '../Date';
import Span from '../Span';
import {saveItem,getItem} from '../../api';
import {getUrlVars} from '../../Constants/functions'
const formName='Display'
class ItemForm extends React.Component{
        constructor(props){
            super(props);
        }
        componentDidMount=(e)=>{
            let itmId=getUrlVars()['ID'];
            console.log('itmid',itmId);
            if(formName!='New')
            {
                getItem(itmId).then((result)=>{
                    console.log('result',result.data);
                    this.props.dispatch(setItem(result.data));
                    console.log('itm',this.props.item);
                })
            }
        }

    handleSubmit=(e)=>{
        e.preventDefault();
    console.log('item',this.props.item);
            saveItem(this.props.item).then((response)=>{
                console.log('save res', response);

                this.props.dispatch(addItem(this.props.item));
                //this.getTitle.value='';
              //  this.getDescription.value='';
               this.props.dispatch(setItem({}));

            }).catch((error)=>console.log(error));
         
    }
    render(){
        return(
            <div>
                <h1> Create Item</h1>
                <form onSubmit={this.handleSubmit}>

                   <div>
                       <Label value='عنوان' />
                       { formName!='Display'?
                       <Text  render={TextWid} internalName={'Title'} />:
                       <Span  value={this.props.item['Title']}   />}
                   </div><br/>
                   <div><Label value='توضیحات'/>{formName!='Display'?<TextArea render={TextAreaWid} placeholder='Enter Item Description' />:<Span  value={this.props.item['Title']}   />}</div><br/>
                   <div><Label value='طول جغرافیایی'/>{formName!='Display'?<Number required render={NumberWid} internalName='LongitudeWell' placeholder="Enter LongitudeWell" />:<Span  value={this.props.item['LongitudeWell']}/>}</div><br/>
                   <div><Label value='عرض جغرافیایی'/>{formName!='Display'?<Number required render={NumberWid} internalName='LatitudeWell'  placeholder="Enter LatitudeWell" />:<Span  value={this.props.item['LatitudeWell']}/>}</div><br/>
                   <div><Label value='DateCensus'/>{formName!='Display'?<Date required  render={DateWid} internalName='DateCensus' placeholder="Enter DateCensus" />:<Span  value={moment(this.props.item['DateCensus']).format('jYYYY/jMM/jDD')} />}</div><br/>
                   <div> <Label value='کد مالک' />{formName!='Display'?<Text required render={TextWid} internalName='OwnerCode' placeholder='Enter Item Title'  />:<Span  value={this.props.item['OwnerCode']} />}</div><br/>
                   <div> <Label value='موبایل مالک' />{formName!='Display'?<Text required render={TextWid} internalName='OwnerMobile' placeholder='Enter Item Title'  />:<Span  value={this.props.item['OwnerMobile']} />}</div><br/>
                   <div> <Label value='ElectricityCode' />{formName!='Display'?<Text required render={TextWid} internalName='ElectricityCode' placeholder='Enter Item Title'  />:<Span  value={this.props.item['ElectricityCode']} />}</div><br/>
                   <div> <Label value='SerialNumberMeter' />{formName!='Display'?<Text required render={TextWid} internalName='SerialNumberMeter' placeholder='Enter Item Title'  />:<Span  value={this.props.item['SerialNumberMeter']} />}</div><br/>
                   <div> <Label value='SerialNumberModem' />{formName!='Display'?<Text required render={TextWid} internalName='SerialNumberModem' placeholder='Enter Item Title'  />:<Span  value={this.props.item['SerialNumberModem']} />}</div><br/>
                   <div> <Label value='ManufacturerMeter' />{formName!='Display'?<Text required render={TextWid} internalName='ManufacturerMeter' placeholder='Enter Item Title'  />:<Span  value={this.props.item['ManufacturerMeter']} />}</div><br/>
                   <div> <Label value='DateInstallationMeter' />{formName!='Display'?<Date required render={DateWid} internalName='DateInstallationMeter' placeholder='Enter Item Title'  />:<Span  value={moment(this.props.item['DateInstallationMeter']).format('jYYYY/jMM/jDD')} />}</div><br/>
                   <div> <Label value='TypeMeter' />{formName!='Display'?<Text required render={TextWid} internalName='TypeMeter' placeholder='Enter Item Title'  />:<Span  value={this.props.item['TypeMeter']} />}</div><br/>
                   <div> <Label value='NumberMeters' />{formName!='Display'?<Text required render={TextWid} internalName='NumberMeters' placeholder='Enter Item Title'  />:<Span  value={this.props.item['NumberMeters']} />}</div><br/>
                   <div> <Label value='WaterSystem' />{formName!='Display'?<Text required render={TextWid} internalName='WaterSystem' placeholder='Enter Item Title'  />:<Span  value={this.props.item['WaterSystem']} />}</div><br/>
                   <div> <Label value='حجم مجاز برداشت(متر مکعب در سال)' />{formName!='Display'?<Number required render={NumberWid} internalName='ApprovedVolume' placeholder='Enter Item Title'  />:<Span  value={this.props.item['ApprovedVolume']} />}</div><br/>
                   <div> <Label value='ساعت کارکرد سالانه' />{formName!='Display'?<Number required render={NumberWid} internalName='WorkHours' placeholder='Enter Item Title'  />:<Span  value={this.props.item['WorkHours']} />}</div><br/>
                   <div> <Label value='WaterMeasurementMethod' />{formName!='Display'?<Text required render={TextWid} internalName='WaterMeasurementMethod' placeholder='Enter Item Title'  />:<Span  value={this.props.item['WorkHours']} />}</div><br/>
                   <div> <Label value='EC' />{formName!='Display'?<Number required render={NumberWid} internalName='EC' placeholder='Enter Item Title'  />:<Span  value={this.props.item['EC']} />}</div><br/>
                   <div> <Label value='DEBI' />{formName!='Display'?<Number required render={NumberWid} internalName='DEBI' placeholder='Enter Item Title'  />:<Span  value={this.props.item['DEBI']} />}</div><br/>
                   <div> <Label value='PresentSituation' />{formName!='Display'?<Text required render={TextWid} internalName='PresentSituation' placeholder='Enter Item Title'  />:<Span  value={this.props.item['PresentSituation']} />}</div><br/>
                   <div> <Label value='DiameterWaterPipe' />{formName!='Display'?<Number render={NumberWid} required  internalName='DiameterWaterPipe' placeholder='Enter Item Title'  />:<Span  value={this.props.item['DiameterWaterPipe']} />}</div><br/>
                   <div> <Label value='YearDig ' />{formName!='Display'?<Number required render={NumberWid} internalName='YearDig' placeholder='Enter Item Title'  />:<Span  value={this.props.item['YearDig']} />}</div><br/>
                   <div> <Label value='میزان قدرت(برق)' />{formName!='Display'?<Number required render={NumberWid} internalName='PowerlevelElectricity' placeholder='Enter Item Title'  />:<Span  value={this.props.item['PowerlevelElectricity']} />}</div><br/>
                   <div> <Label value='میزان قدرت (دیزل)' />{formName!='Display'?<Number required render={NumberWid} internalName='PowerlevelDiesel' placeholder='Enter Item Title'  />:<Span  value={this.props.item['PowerlevelDiesel']} />}</div><br/>
                   <div> <Label value='ArtifactsType' />{formName!='Display'?<Text required render={TextWid} internalName='ArtifactsType' placeholder='Enter Item Title'  />:<Span  value={this.props.item['ArtifactsType']} />}</div><br/>
                   <div> <Label value='AreaUnderCultivation' />{formName!='Display'?<Number required render={NumberWid} internalName='AreaUnderCultivation' placeholder='Enter Item Title'  />:<Span  value={this.props.item['AreaUnderCultivation']} />}</div><br/>
                   <div> <Label value='CultivarType' />{formName!='Display'?<Text required render={TextWid} internalName='CultivarType' placeholder='Enter Item Title'  />:<Span  value={this.props.item['CultivarType']} />}</div><br/>
                   <div> <Label value='نوع مصرف آب بر اساس پرونده بهره برداری' />{formName!='Display'?<Text required render={TextWid} internalName='KindConsumptionWater' placeholder='Enter Item Title'  />:<Span  value={this.props.item['KindConsumptionWater']} />}</div><br/>
                   <div> <Label value='لوله جدار' />{formName!='Display'?<Text required render={TextWid} internalName='KindPipeline' placeholder='Enter Item Title'  />:<Span  value={this.props.item['KindPipeline']} />}</div><br/>
                   <div> <Label value='عمق چاه' />{formName!='Display'?<Number required render={NumberWid} internalName='WellDepth'placeholder='Enter Item Title'  />:<Span  value={this.props.item['WellDepth']} />}</div><br/>
                   <div> <Label value='سطح آب' />{formName!='Display'?<Number required render={NumberWid} internalName='WaterSurface' placeholder='Enter Item Title'  />:<Span  value={this.props.item['WaterSurface']} />}</div><br/>
                    
                   
                    <button>Create Item</button>

                </form>
                </div>
        )
    }
}
const mapStateToProps=state=>({
    item:state.item
})
export default connect(mapStateToProps)(ItemForm)