import React, {useState, useEffect} from 'react';
import axios from 'axios';
import ContentItem from './components/ContentItem';
import HeaderItem from './components/HeaderItem';
import FooterItem from './components/FooterItem';

const baseUrl = "https://jsonplaceholder.typicode.com/posts";


const HomePage = () =>
{
    const value = "Какое-то название";

    const[labels, setLabels] = useState([

    ]);



    useEffect(() => {

        axios.get(baseUrl)
        .then(res => 
        {


            setLabels(res.data);  
        });

    });

    return(
        <div className='container col-10'>
            <HeaderItem headerText={value }/>
            <ContentItem 
                setOfLabels= {labels}
            />
            <FooterItem />
        </div>
    )
}

export default HomePage;