import { useState } from 'react';
import reactLogo from './assets/react.svg';
import viteLogo from '/vite.svg';
import './App.css';
import { Asociados } from './components/Asociados';
import { CV } from './components/CV';
import { Cuotas } from './components/Cuotas';
import { Ofertas } from './components/Ofertas';
import { Eventos } from './components/Eventos';
import { Asistencias } from './components/Asistencias';

function App() {
  const [count, setCount] = useState(0);

  return (
    <>
      <Asociados />
      <CV />
      <Cuotas />
      <Ofertas />
      <Eventos />
      <Asistencias />
    </>
  );
}
export default App;
