import React from 'react';
import {connect} from 'react-redux';
import {setFieldValue} from '../../store/action';
import {getAllItem} from '../../api';
 class Lookup extends  React.Component{
constructor(props){
     super(props);
     this.state={
         options:[],
       value:0,
         selectedText:''
     }
}
    handleChange = (e) => {
        console.log('change', e.target.value)
        console.log('sdfsdfsf', this.props.field)
        const {options, selectedIndex} = e.target;
    //console.log(options[selectedIndex].innerHTML);
       this.setState({value:e.target.value,selectedText:options[selectedIndex].innerHTML})
        // if (this.props.multiple) {
        //     var options = e.target.options;
        //     var value = "";
        //     for (var i = 0, l = options.length; i < l; i++) {
        //         if (options[i].selected) {
        //             value += (options[i].value) + ",";
        //         }
                
        //     }
        //     value.slice(0, -1);
        //     this.props.dispatch(changeField(this.props.internalName,value))
        // }
        // else {
            this.props.dispatch(setFieldValue(this.props.internalName,e.target.value,this.props.storeIndex))
            this.props.dispatch(setFieldValue(this.props.internalName.substring(0,this.props.internalName.length-2),{'ID':e.target.value,[this.props.field['TitleField']]:options[selectedIndex].innerHTML},this.props.storeIndex))
    }
componentDidMount(){

    let field=this.props.field;
    
    getAllItem(field.Options[0],'ID,'+this.props.field.TitleField).then((result)=>{

       this.setState({options:result.data,value:this.props.value,selectedText:this.props.lookupField? this.props.lookupField[this.props.field['TitleField']]:''});
        console.log('options',result);
       // this.props.dispatch(setFieldValue(this.props.internalName,this.state.options[0].ID,this.props.storeIndex));

    })

}
render(){
    
  return this.props.render({value:this.state.value,internalName:this.props.field.accessor,multiple:this.props.field.IsMulti,options:this.state.options,titleField:this.props.field.TitleField, onChange: this.handleChange,formName:this.props.formName })
}

 }
 const mapStateToProps=(state,props)=>(console.log('lookupfield', state.item[props.storeIndex][props.internalName.substring(0,props.internalName.length-2)]),{
   
    item:state.item[props.storeIndex],
    field:state.columns[props.storeIndex].find((field)=>field.accessor==props.internalName),
    lookupField:state.item[props.storeIndex][props.internalName.substring(0,props.internalName.length-2)],
    value:state.item[props.storeIndex][props.internalName]
 })
 export default connect(mapStateToProps)(Lookup)

