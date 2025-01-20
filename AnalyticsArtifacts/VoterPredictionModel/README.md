# 📊 Predictive Legislative Outcome Model

Welcome to **Predictive Legislative Outcome Model**, a data mining project that uses the CRISP-DM framework to predict the outcome of congressional votes on an education-spending bill. This project leverages historical voting data and classification models to provide stakeholders with actionable insights into legislative outcomes. View the model presentation file for details on the project. 

---

## 🕹️ **How to Use**
- The project is implemented using **RapidMiner** for data preparation, modeling, and evaluation.
- Input historical voting data (e.g., `vote-train.csv` for training and `vote-predict-vote.csv` for prediction).
- Run classification models, including:
  - Decision Tree
  - Logistic Regression
  - k-Nearest Neighbors (k-NN)
- Evaluate model outputs using performance metrics (accuracy, precision, recall, lift chart).
- Select the best-performing model (Naive Bayes) based on evaluation metrics.
- Use the selected model to predict the likelihood of passing the education-spending bill.

---

## ⚙️ **Features**
- **CRISP-DM Framework**: Implemented all six phases:
  1. Business Understanding
  2. Data Understanding
  3. Data Preparation
  4. Modeling
  5. Evaluation
  6. Deployment
- **Data Mining**:
  - Cleaned and analyzed historical congressional voting datasets.
  - Built and evaluated three classification models:
    - Decision Trees
    - Logistic Regression
    - k-Nearest Neighbors (k-NN)
- **Model Evaluation**:
  - Decision Tree: Interpretable decision-making paths.
  - Naive Bayes: Highest accuracy and recall for predicting "Yes" votes.
  - k-Nearest Neighbors: Explored but not selected due to performance limitations.
  - Lift charts and confusion matrices to compare model effectiveness.
- **Team Collaboration**:
  - Worked with a team to deliver a comprehensive presentation on project findings.
  - Presented actionable insights and future recommendations to stakeholders.
- **Deployment**:
  - Recommended integrating the selected model into a decision-support system.

---

## 🏗️ **Implementation Details**
### **Dataset Overview**
- **Training Dataset**: `vote-train.csv`  
  - Records: 400  
  - Attributes: 17 (categorical and binomial variables).
- **Prediction Dataset**: `vote-predict-vote.csv`  
  - Records: 35  
  - Target Variable: Education Spending (Yes, No, Abstain).

### **Classification Models**
1. **Decision Tree**:
   - Provided clear decision-making paths.
   - Lower accuracy compared to other models.
2. **Naive Bayes**:
   - Achieved the highest accuracy and recall.
   - Selected as the best-performing model for deployment.
3. **k-Nearest Neighbors (k-NN)**:
   - Explored for its simplicity and flexibility.
   - Performance was lower compared to Naive Bayes.
4. **Logistic Regression**:
   - Explored for its interpretability but not selected due to lower recall.

### **Evaluation Metrics**
- **Naive Bayes**:
  - Accuracy: 80.83%
  - Precision: 81.63%
  - Recall: 86.96%
  - Lift Chart: 100% confidence for "Yes" votes in the top 10% of predictions.
- **Decision Tree**:
  - Accuracy: 75.83%
  - Precision: 73.47%
  - Recall: 78.26%
  - Lift Chart: Strong performance but lower than Naive Bayes.

---

## 📋 **Sample Output**
```text
Predicted Results for Education Spending Bill:
- Total "Yes" Votes: 17
- Total "No" Votes: 14
- Total "Abstain" Votes: 4

Naive Bayes Model Evaluation:
- Accuracy: 80.83%
- Precision: 81.63%
- Recall: 86.96%
- Lift Chart: 100% confidence in top 10% predictions.
```
---

## 💻 **Technologies Used**
- **RapidMiner**: Data preparation, modeling, and evaluation.  
- **CRISP-DM Framework**: Structured approach to data mining.  
- **CSV Datasets**: Historical voting data from Congress.  

---

## ✨ **Future Enhancements**
- Expand the model to incorporate contextual factors like economic or political climates.  
- Integrate the model into a web-based decision-support tool for real-time predictions.  
- Test the model on additional datasets to evaluate its robustness and adaptability.  
- Include visualizations to improve interpretability for non-technical stakeholders.  

---

## 📧 **Contact**
For questions or feedback, feel free to reach out:  
📧 [rgarcia.pm@icloud.com](mailto:rgarcia.pm@icloud.com)  
🔗 [LinkedIn Profile](https://www.linkedin.com/in/rg-garcia)  

