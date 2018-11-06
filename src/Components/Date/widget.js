import React from 'react'
import moment from 'moment-jalaali'
//import moment from 'moment';
import {DatePicker} from "react-advance-jalaali-datepicker";
// import { Calendar, DatePicker } from 'react-persian-datepicker';

const DateWid=({internalName,value,onChange})=>(
              <div className="datePicker">
                <DatePicker
                    placeholder="انتخاب تاریخ"
                    format="jYYYY/jMM/jDD"
                    onChange={onChange}
                    id="datePicker"
                    preSelected={value}
                    /> 
                </div>
)

export default DateWid

const styles = {
    calendarContainer: "calendarContainer",
    dayPickerContainer: "dayPickerContainer",
    monthsList: "monthsList",
    daysOfWeek: "daysOfWeek",
    dayWrapper: "dayWrapper",
    selected: "selected",
    heading: "heading",
    next: "next",
    prev: "prev",
    title: "title",
    }
{/* <div><DatePicker onChange={onChange}  calendarStyles={styles} value={value} inputFormat="jYYYY/jM/jD" /></div> */}