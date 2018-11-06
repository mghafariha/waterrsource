import React from 'react';
import {connect} from 'react-redux';
import {setFieldValue} from '../../store/action'

class Select extends React.Component{

    constructor(props)
    {
        super(props);
       this.state={ selectedOption: null, multiValue: []}
    }
    componentWillReceiveProps(nextProps) {
        if(nextProps.value !== this.props.value &&  nextProps.value) {
          this.setState({selectedOption: nextProps.value.split(',').map(itm=>({value:itm, label:itm}))});
        }
      }
    handleChange=(selectedOption)=>{
        this.setState({ selectedOption });
       var options = selectedOption;
        if(Array.isArray(options))
       {
            var value = "";
          
         value=  options.reduce((acc, itm)=> {
            return acc + itm.value + ",";
          }, '');
            value.slice(0, -1);
            console.log('reduce',value)
            this.props.dispatch(setFieldValue(this.props.internalName, value.slice(0, -1),this.props.storeIndex))
            
         }
        else {
             this.props.dispatch(setFieldValue(this.props.internalName,selectedOption.value,this.props.storeIndex))
         }
    }
    // componentDidMount(){
    //         console.log('selected ',this.props.value);
    //         this.props.dispatch(setFieldValue(this.props.internalName,this.props.item[this.props.internalName],this.props.storeIndex));
    //          this.setState({selectedOption:this.props.value.split(',').map(itm=>({value:itm, label:itm}))})
            
    // }
    render(){
        const { selectedOption } = this.state;
      //  let value=this.props.item[this.props.internalName] ;
           return this.props.render({value: selectedOption,internalName:this.props.field.accessor,multiple:this.props.field.IsMulti,options:this.props.field.Options.map(opt=>({value: opt, label: opt})), onChange: this.handleChange })
    }
}
const mapStateToProps=(state,props)=>({
    item:state.item[props.storeIndex],
    field:state.columns[props.storeIndex].find((field)=>field.accessor==props.internalName),
    value:state.item[props.storeIndex][props.internalName]
 })
 export default connect(mapStateToProps)(Select)