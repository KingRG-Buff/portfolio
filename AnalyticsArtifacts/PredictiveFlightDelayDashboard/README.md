# ✈️ Predictive Flight Delay Dashboard

Welcome to **Predictive Flight Delay Dashboard**, a data-driven project designed as proof of concept to monitor and predict flight delays. This initiative leverages Azure Machine Learning (ML) and Power BI to provide actionable insights for improving operational efficiency and enhancing customer satisfaction in the aviation industry.

---

## 🕹️ **How to Use**
1. Historical flight data is collected and processed to predict delays for flights departing within the next hour.
2. The predictive model is trained using Azure ML, incorporating factors like:
   - Departure time
   - Carrier
   - Origin and destination
   - Historical delay patterns
3. Predictions are exported via Azure ML endpoints and integrated into Power BI for real-time visualizations.
4. The Power BI dashboard highlights key metrics, patterns, and root causes of flight delays to assist carriers in implementing operational improvements.

---

## ⚙️ **Features**
- **CRISP-DM Framework**:
  - Business Understanding: Focused on reducing flight delays through predictive modeling and actionable insights.
  - Data Understanding: Analyzed historical flight performance data to identify key delay factors.
  - Data Preparation: Handled missing values, encoded categorical variables, and merged datasets for model readiness.
  - Modeling: Trained and validated classification models using Azure ML, selecting the best-performing model.
  - Evaluation: Assessed accuracy, precision, recall, and F1-score to refine the model.
  - Deployment: Integrated the model with Power BI for visualization and operational use.
- **Interactive Dashboard**:
  - Displays metrics like percentage of delayed flights, average delay time, and delay distribution by carrier and location.
  - Includes heatmaps, bar charts, and trend lines for root cause analysis.
- **Predictive Model**:
  - Provides real-time predictions to flag flights at risk of delays, enabling early intervention and improvement planning.

---

## 🏗️ **Implementation Details**
### **Dataset Overview**
- Data collected from open source air traffic control systems.
- Historical flight data includes attributes such as flight number, origin, destination, departure time, and delay history.
- Data preparation included cleaning, feature engineering, and handling missing values to ensure high-quality input for the ML model.

### **Modeling Process**
1. **Model Selection**: Used Azure ML’s automated machine learning to identify the most suitable model.
2. **Evaluation Metrics**:
   - Accuracy: Key metric for model performance.
   - Precision and Recall: Balanced approach to identifying high-risk delays.
   - F1-Score: Comprehensive performance indicator for imbalanced datasets.
3. **Deployment**: Azure ML endpoints were created for real-time prediction integration.

### **Visualization in Power BI**
- Designed an intuitive and interactive dashboard for stakeholders.
- Key components include:
  - Heatmaps for high-delay routes.
  - Trend lines for delay analysis over time.
  - Carrier performance comparison charts.

---

## 📋 **Sample Output**
```text
Dashboard Highlights:
- Delayed Flights: 15%
- Average Delay Time: 12 minutes
- Top Delayed Routes:
  - AUS → DFW: 23%
  - LAX → JFK: 18%

Predicted High-Risk Flights:
- Flight 123 (Carrier A): High Delay Probability (80%)
- Flight 456 (Carrier B): Moderate Delay Probability (65%)
```
---

## 💻 **Technologies Used**
- **Azure Machine Learning**: Data preparation, modeling, and deployment.  
- **Power BI**: Real-time data visualization and root cause analysis.  
- **CRISP-DM Framework**: Structured approach for predictive modeling.  
- **CSV Datasets**: Historical flight data for analysis.  

---

## ✨ **Future Enhancements**
- Add new variables like weather conditions, holidays, and time of day to improve predictive accuracy.
- Implement real-time data collection pipelines for continuous updates.  
- Expand model features to include live weather and air traffic data.  
- Develop a mobile application to provide alerts for flight delays.  
- Integrate a recommendation system for carriers to optimize scheduling and routes.

---

## 📧 **Contact**
For questions or feedback, feel free to reach out:  
📧 [rgarcia.pm@icloud.com](mailto:rgarcia.pm@icloud.com)  
🔗 [LinkedIn Profile](https://www.linkedin.com/in/rg-garcia)  
