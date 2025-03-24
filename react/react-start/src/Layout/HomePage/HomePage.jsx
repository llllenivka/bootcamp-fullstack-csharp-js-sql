import React from 'react';
import ContentItem from './components/ContentItem';
import HeaderItem from './components/HeaderItem';
import FooterItem from './components/FooterItem';

const HomePage = () =>
{
    return(
        <div className='container col-10'>
            <HeaderItem/>
            <ContentItem/>
            <FooterItem/>
        </div>
    )
}

export default HomePage;