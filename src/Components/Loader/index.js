import React from 'react';
import ReactLoading from 'react-loading';

class Loader extends React.Component{

    render(){
       return( <ReactLoading type='balls' color='gray' height={200} width={100} />)
    }
}
export default Loader